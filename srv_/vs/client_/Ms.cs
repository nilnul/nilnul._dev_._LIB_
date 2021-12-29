using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.srv_.vs.client_
{
	/// <summary>
	/// 
	/// </summary>
	public interface MsI
	{
		/*
		using Microsoft.VisualStudio.Services.Common;
using Microsoft.VisualStudio.Services.Client;
using Microsoft.TeamFoundation.SourceControl.WebApi;

const String c_collectionUri = "https://fabrikam.visualstudio.com/DefaultCollection";
	const String c_projectName = "MyGreatProject";
	const String c_repoName = "MyRepo";

	// Interactively ask the user for credentials, caching them so the user isn't constantly prompted
	VssCredentials creds = new VssClientCredentials();
	creds.Storage = new VssClientCredentialStorage();

	// Connect to VSTS
	VssConnection connection = new VssConnection(new Uri(c_collectionUri), creds);

	// Get a GitHttpClient to talk to the Git endpoints
	GitHttpClient gitClient = connection.GetClient<GitHttpClient>();

	// Get data about a specific repository
	var repo = gitClient.GetRepositoryAsync(c_projectName, c_repoName).Result;
	*/
	}
}
