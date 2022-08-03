# Introduction
This article series will walk you through the steps necessary to create a new ABP application using the latest available build with the OpenIddict identity server and connecting that application to Zapier to extend the automation capabilities of your application without needing to build custom integrations.

This will be a 3 part series covering different aspects of this process for clarity:

- [Part 1) Connecting your ABP app to Zapier](/part1/readme.md)
- [Part 2) Creating a Zap from the ABP API](/part2/readme.md)
- [Part 3) ABP Commercial CMSKit Social Automation](/part3/readme.md)

The third part of the series will not be contained withing the source code and will focus primarily on the Zapier side, but it is an interesting use case for the setup (and my original motivation for figuring this out) so I thought I would include it.

# Source Code
The source code for the ABP application utilized during this article can be found [on Github](https://github.com/Byteology-LLC/ZapierDemo)

# Requirements
The code for this project requires the following:
	- ABP Framework 6.0.0-rc.1 (for latest available OpenIddict features)
	- MongoDb
	- Visual Studio (other IDEs will work, but this article has some Visual Studio specific stuff that you will need to adapt to any other IDE)

**Additionally, in order for Zapier to work correctly it will need to be able to access the API. Generally this means that you need to have a publicly routed domain name.**

If you need help, here is a really good article I found that helps walk you through setting up your development environment with a custom domain: <https://dotnetplaybook.com/custom-local-domain-using-https-kestrel-asp-net-core/>

You will also need an SSL certificate. Here are a few good resources for getting free LetsEncrypt certificates for domains you own for your personal projects:
- <https://certifytheweb.com/>
- <https://github.com/rmbolger/Posh-ACME>

If you are still struggling with allowing public access to your development environment, let me know if the comments and I will throw together a more comprehensive tutorial on how to get it done.