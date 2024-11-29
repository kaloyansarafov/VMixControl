using VMixHTTP;


var client = new vMixClient("http://localhost:8088");
vMix vmix = vMixXMLParser.Parse(await client.GetvMixAsync());
Console.WriteLine($"vMix version: {vmix.Version}");

string input = "scr browser";
vMixInput? inputInfo = vmix.Inputs?.FirstOrDefault(i => i.Title == input);
Console.WriteLine($"Input Audio muted?: {inputInfo?.Muted}");

Console.WriteLine($"Muting/Unmuting audio of input {input}...");
string response = await client.AudioMuteUnmuteAsync(input);
Console.WriteLine(response);

vmix = vMixXMLParser.Parse(await client.GetvMixAsync());
inputInfo = vmix.Inputs?.FirstOrDefault(i => i.Title == input);
Console.WriteLine($"Input Audio muted?: {inputInfo?.Muted}");

