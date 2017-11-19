module.exports = function () {
  var instanceRoot = "C:\\inetpub\\wwwroot\\habitat";
  var config = {
    websiteRoot: instanceRoot + "\\Website",
    sitecoreLibraries: instanceRoot + "\\Website\\bin",
    licensePath: instanceRoot + "\\Data\\license.xml",
    solutionName: "Habitat",
    buildConfiguration: "Debug",
    buildPlatform: "Any CPU",
    buildToolsVersion: 'auto', //change to 15.0 for VS2017 support
    publishPlatform: "AnyCpu",
    runCleanBuilds: false
  };
  return config;
}
