namespace VMixHTTP;

using VMixHTTP.Audio;

/// <summary>
/// Represents a client for interacting with the vMix HTTP API.
/// </summary>
public class vMixClient
{
    private readonly HttpClient _client;
    private readonly string _url;

    /// <summary>
    /// Initializes a new instance of the <see cref="vMixClient"/> class.
    /// </summary>
    /// <param name="url">The base URL of the vMix instance.</param>
    public vMixClient(string url)
    {
        _client = new HttpClient();
        _url = url;
    }

    /// <summary>
    /// Gets the version of the wrapper.
    /// </summary>
    /// <returns>The wrapper version.</returns>
    public string GetWrapperVersion()
    {
        return "0.0.1";
    }

    /// <summary>
    /// Gets the details of the vMix instance asynchronously.
    /// </summary>
    /// <returns>A task that represents the asynchronous operation. The task result contains the vMix information in XML format.</returns>
    public async Task<string> GetvMixAsync()
    {
        //should return xml with information about the vMix instance
        return await SendRequestAsync("");
    }

    /// <summary>
    /// Sends a request to the vMix API asynchronously.
    /// </summary>
    /// <param name="request">The request string to be sent to the API.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains the API response.</returns>
    private async Task<string> SendRequestAsync(string request)
    {
        var response = await _client.GetAsync($"{_url}/api/?{request}");
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }

    /// <summary>
    /// Mutes or unmutes the audio of the specified input asynchronously.
    /// </summary>
    /// <param name="input">The input identifier.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains the API response.</returns>
    public async Task<string> AudioMuteUnmuteAsync(string input)
    {
        return await SendRequestAsync(Audio.Audio.AudioMuteUnmute(input));
    }

    /// <summary>
    /// Sets the audio of the specified input to auto mode asynchronously.
    /// </summary>
    /// <param name="input">The input identifier.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains the API response.</returns>
    public async Task<string> AudioAutoAsync(string input)
    {
        return await SendRequestAsync(Audio.Audio.AudioAuto(input));
    }

    /// <summary>
    /// Turns off the auto mode for the audio of the specified input asynchronously.
    /// </summary>
    /// <param name="input">The input identifier.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains the API response.</returns>
    public async Task<string> AudioAutoOffAsync(string input)
    {
        return await SendRequestAsync(Audio.Audio.AudioAutoOff(input));
    }

    /// <summary>
    /// Turns on the auto mode for the audio of the specified input asynchronously.
    /// </summary>
    /// <param name="input">The input identifier.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains the API response.</returns>
    public async Task<string> AudioAutoOnAsync(string input)
    {
        return await SendRequestAsync(Audio.Audio.AudioAutoOn(input));
    }

    /// <summary>
    /// Assigns the specified input to the specified audio bus asynchronously.
    /// </summary>
    /// <param name="input">The input identifier.</param>
    /// <param name="bus">The bus identifier.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains the API response.</returns>
    public async Task<string> AudioBusAsync(string input, string bus)
    {
        return await SendRequestAsync(Audio.Audio.AudioBus(input, bus));
    }

    /// <summary>
    /// Removes the specified input from the specified audio bus asynchronously.
    /// </summary>
    /// <param name="input">The input identifier.</param>
    /// <param name="bus">The bus identifier.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains the API response.</returns>
    public async Task<string> AudioBusOffAsync(string input, string bus)
    {
        return await SendRequestAsync(Audio.Audio.AudioBusOff(input, bus));
    }

    /// <summary>
    /// Adds the specified input to the specified audio bus asynchronously.
    /// </summary>
    /// <param name="input">The input identifier.</param>
    /// <param name="bus">The bus identifier.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains the API response.</returns>
    public async Task<string> AudioBusOnAsync(string input, string bus)
    {
        return await SendRequestAsync(Audio.Audio.AudioBusOn(input, bus));
    }

    /// <summary>
    /// Applies the specified matrix preset to the audio channel of the specified input asynchronously.
    /// </summary>
    /// <param name="input">The input identifier.</param>
    /// <param name="preset">The matrix preset identifier.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains the API response.</returns>
    public async Task<string> AudioChannelApplyMatrixPresetAsync(string input, string preset)
    {
        return await SendRequestAsync(Audio.Audio.AudioChannelApplyMatrixPreset(input, preset));
    }

    /// <summary>
    /// Shows or hides the audio mixer asynchronously.
    /// </summary>
    /// <returns>A task that represents the asynchronous operation. The task result contains the API response.</returns>
    public async Task<string> AudioMixerShowHideAsync()
    {
        return await SendRequestAsync(Audio.Audio.AudioMixerShowHide());
    }

    /// <summary>
    /// Turns off the audio of the specified input asynchronously.
    /// </summary>
    /// <param name="input">The input identifier.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains the API response.</returns>
    public async Task<string> AudioOffAsync(string input)
    {
        return await SendRequestAsync(Audio.Audio.AudioOff(input));
    }

    /// <summary>
    /// Turns on the audio of the specified input asynchronously.
    /// </summary>
    /// <param name="input">The input identifier.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains the API response.</returns>
    public async Task<string> AudioOnAsync(string input)
    {
        return await SendRequestAsync(Audio.Audio.AudioOn(input));
    }

    public async Task<string> AudioPluginOnAsync(string input, int pluginNumber)
    {
        return await SendRequestAsync(Audio.Audio.AudioPluginOn(input, pluginNumber));
    }

    public async Task<string> AudioPluginOffAsync(string input, int pluginNumber)
    {
        return await SendRequestAsync(Audio.Audio.AudioPluginOff(input, pluginNumber));
    }

    public async Task<string> AudioPluginOnOffAsync(string input, int pluginNumber)
    {
        return await SendRequestAsync(Audio.Audio.AudioPluginOnOff(input, pluginNumber));
    }
    
    public async Task<string> AudioPluginShowAsync(string input, int pluginNumber)
    {
        return await SendRequestAsync(Audio.Audio.AudioPluginShow(input, pluginNumber));
    }
}