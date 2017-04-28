# TeamsTab
Default Scafolding For Creating a Tab in Microsoft Teams

This is a Microsoft .Net Core Web Applications which shows some basic scafolding for Microsoft Teams.

In order to run this with teams you will need to run ngrok to get a HTTPS connection to your local machine.

Once you start ngrok you need to update the ngrok domain inside:
- config.html
- manifest.json
- index.cshtml

manifest.json should be zipped in order to create the Teams Side Load package.

Note that "neeedsIdentity" must be true in the manifest.json in order for the user data to be passed to the tab OR available via getSettings javascript.
