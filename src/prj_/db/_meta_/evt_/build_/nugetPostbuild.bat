﻿
rem /*
 
rem nugetPostBuild.bat
  
setlocal
		@rem		set date0=%date%
		@rem %date% is susceptible to regional format settintings

for /F "usebackq tokens=1,2 delims==" %%i in (`wmic os get LocalDateTime /VALUE 2^>NUL`) do if '.%%i.' == '.LocalDateTime.' set ldt =%% j
set ldt =% ldt:~0,4 % -% ldt:~4,2 % -% ldt:~6,2 % % ldt:~8,2 %:% ldt:~10,2 %:% ldt:~12,6 %
			  echo Local date is [%ldt%]

set date0 =% ldt %

					  set	year=%date0:~2,2 %
					  set month =% date0:~5,2 %
						set     day =% date0:~8,2 %
						  echo year month day: % year % % month % % day %

				  @rem The 3rd number is the number of days since the year 2000, and the 4th number is the number of seconds since midnight (divided by 2) without taking into account of timezone offset.
		@rem set time0=%time%

@rem		set hour=%time0:~0,2 %
@rem        set min =% time0:~3,2 %
  @rem        set sec =% time0:~6,2 %

			set hour =% date0:~11,2 %
			  set min =% date0:~14,2 %
				set sec =% date0:~17,2 %

				  echo hour min sec: % hour % % min % % sec %
				  set / a p = year * 366 + month * 30 + day
		echo patch: % p %
		set / a b = (hour * 3600 + min * 60 + sec) / 2
		echo build: % b %




		set pb =% p %.% b %
		set v = 1.0.% pb %
		echo % v %
		set pkg = nilnul._map_._DB_.% v %.nupkg
		echo % pkg %

		nuget pack - prop configuration = Release - Version % v %
		 "NuGet.exe" push % pkg % -Source local
		"NuGet.exe" push % pkg % -Source wyt

endlocal
pause

rem */
