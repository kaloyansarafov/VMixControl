using System.Globalization;

namespace VMixHTTP.Audio;

internal static class Audio
{
    internal static string AudioMuteUnmute(string input)
    {
        input = Uri.EscapeDataString(input);
        return $"Function=Audio&Input={input}";
    }

    internal static string AudioAuto(string input)
    {
        input = Uri.EscapeDataString(input);
        return $"Function=AudioAuto&Input={input}";
    }

    internal static string AudioAutoOff(string input)
    {
        input = Uri.EscapeDataString(input);
        return $"Function=AudioAutoOff&Input={input}";
    }

    internal static string AudioAutoOn(string input)
    {
        input = Uri.EscapeDataString(input);
        return $"Function=AudioAutoOn&Input={input}";
    }
    
    internal static string AudioBus(string input, string bus)
    {
        input = Uri.EscapeDataString(input);
        return $"Function=AudioBus&Input={input}&Value={bus}";
    }
    
    internal static string AudioBusOff(string input, string bus)
    {
        input = Uri.EscapeDataString(input);
        return $"Function=AudioBusOff&Input={input}&Value={bus}";
    }
    
    internal static string AudioBusOn(string input, string bus)
    {
        input = Uri.EscapeDataString(input);
        return $"Function=AudioBusOn&Input={input}&Value={bus}";
    }
    
    internal static string AudioChannelApplyMatrixPreset(string input, string preset)
    {
        input = Uri.EscapeDataString(input);
        return $"Function=AudioChannelApplyMatrixPreset&Input={input}&Value={preset}";
    }
    
    internal static string AudioMixerShowHide()
    {
        return "Function=AudioMixerShowHide";
    }
    
    internal static string AudioOff(string input)
    {
        input = Uri.EscapeDataString(input);
        return $"Function=AudioOff&Input={input}";
    }
    
    internal static string AudioOn(string input)
    {
        input = Uri.EscapeDataString(input);
        return $"Function=AudioOn&Input={input}";
    }
    
    internal static string AudioPluginOn(string input, int pluginNumber)
    {
        input = Uri.EscapeDataString(input);
        return $"Function=AudioPluginOn&Input={input}&Value={pluginNumber}";
    }
    
    internal static string AudioPluginOff(string input, int pluginNumber)
    {
        input = Uri.EscapeDataString(input);
        return $"Function=AudioPluginOff&Input={input}&Value={pluginNumber}";
    }
    
    internal static string AudioPluginOnOff(string input, int pluginNumber)
    {
        input = Uri.EscapeDataString(input);
        return $"Function=AudioPluginOnOff&Input={input}&Value={pluginNumber}";
    }
    
    internal static string AudioPluginShow(string input, int pluginNumber)
    {
        input = Uri.EscapeDataString(input);
        return $"Function=AudioPluginShow&Input={input}&Value={pluginNumber}";
    }

    internal static string BusAAudio()
    {
        return "Function=BusAAudio";
    }
    
    internal static string BusAAudioOff()
    {
        return "Function=BusAAudioOff";
    }
    
    internal static string BusAAudioOn()
    {
        return "Function=BusAAudioOn";
    }

    internal static string BusAAudioPluginOff(int pluginNumber)
    {
        return $"Function=BusAAudioPluginOff&Value={pluginNumber}";
    }
    
    internal static string BusAAudioPluginOn(int pluginNumber)
    {
        return $"Function=BusAAudioPluginOn&Value={pluginNumber}";
    }
    
    internal static string BusAAudioPluginOnOff(int pluginNumber)
    {
        return $"Function=BusAAudioPluginOnOff&Value={pluginNumber}";
    }
    
    internal static string BusAAudioPluginShow(int pluginNumber)
    {
        return $"Function=BusAAudioPluginShow&Value={pluginNumber}";
    }
    
    internal static string BusBAudio()
    {
        return "Function=BusBAudio";
    }
    
    internal static string BusBAudioOff()
    {
        return "Function=BusBAudioOff";
    }
    
    internal static string BusBAudioOn()
    {
        return "Function=BusBAudioOn";
    }
    
    internal static string BusBAudioPluginOff(int pluginNumber)
    {
        return $"Function=BusBAudioPluginOff&Value={pluginNumber}";
    }
    
    internal static string BusBAudioPluginOn(int pluginNumber)
    {
        return $"Function=BusBAudioPluginOn&Value={pluginNumber}";
    }
    
    internal static string BusBAudioPluginOnOff(int pluginNumber)
    {
        return $"Function=BusBAudioPluginOnOff&Value={pluginNumber}";
    }
    
    internal static string BusBAudioPluginShow(int pluginNumber)
    {
        return $"Function=BusBAudioPluginShow&Value={pluginNumber}";
    }
    
    internal static string BusXAudio(string value)
    {
        return $"Function=BusXAudio&Value={value}";
    }
    
    internal static string BusXAudioOff(string value)
    {
        return $"Function=BusXAudioOff&Value={value}";
    }
    
    internal static string BusXAudioOn(string value)
    {
        return $"Function=BusXAudioOn&Value={value}";
    }
    
    internal static string BusXAudioPluginOff(string value, int pluginNumber)
    {
        return $"Function=BusXAudioPluginOff&Value={value},{pluginNumber}";
    }
    
    internal static string BusXAudioPluginOn(string value, int pluginNumber)
    {
        return $"Function=BusXAudioPluginOn&Value={value},{pluginNumber}";
    }
    
    internal static string BusXAudioPluginOnOff(string value, int pluginNumber)
    {
        return $"Function=BusXAudioPluginOnOff&Value={value},{pluginNumber}";
    }
    
    internal static string BusXAudioPluginShow(string value, int pluginNumber)
    {
        return $"Function=BusXAudioPluginShow&Value={value},{pluginNumber}";
    }
    
    internal static string BusXSendToMaster(string value)
    {
        return $"Function=BusXSendToMaster&Value={value}";
    }
    
    internal static string BusXSendToMasterOn(string value)
    {
        return $"Function=BusXSendToMasterOn&Value={value}";
    }
    
    internal static string BusXSendToMasterOff(string value)
    {
        return $"Function=BusXSendToMasterOff&Value={value}";
    }
    
    internal static string BusXSolo(string value)
    {
        return $"Function=BusXSolo&Value={value}";
    }
    
    internal static string BusXSoloOn(string value)
    {
        return $"Function=BusXSoloOn&Value={value}";
    }
    
    internal static string BusXSoloOff(string value)
    {
        return $"Function=BusXSoloOff&Value={value}";
    }
    
    internal static string MasterAudio()
    {
        return "Function=MasterAudio";
    }
    
    internal static string MasterAudioOff()
    {
        return "Function=MasterAudioOff";
    }
    
    internal static string MasterAudioOn()
    {
        return "Function=MasterAudioOn";
    }
    
    internal static string MasterAudioPluginOff(int pluginNumber)
    {
        return $"Function=MasterAudioPluginOff&Value={pluginNumber}";
    }
    
    internal static string MasterAudioPluginOn(int pluginNumber)
    {
        return $"Function=MasterAudioPluginOn&Value={pluginNumber}";
    }
    
    internal static string MasterAudioPluginOnOff(int pluginNumber)
    {
        return $"Function=MasterAudioPluginOnOff&Value={pluginNumber}";
    }
    
    internal static string MasterAudioPluginShow(int pluginNumber)
    {
        return $"Function=MasterAudioPluginShow&Value={pluginNumber}";
    }
    
    internal static string SetBalance(string input, double balance)
    {
        balance = Math.Clamp(balance, -1, 1);
        input = Uri.EscapeDataString(input);
        return $"Function=SetBalance&Input={input}&Value={balance.ToString("0.0", CultureInfo.InvariantCulture)}";
    }
    
    internal static string SetBusAVolume(int volume)
    {
        volume = Math.Clamp(volume, 0, 100);
        return $"Function=SetBusAVolume&Value={volume}";
    }
    
    internal static string SetBusBVolume(int volume)
    {
        volume = Math.Clamp(volume, 0, 100);
        return $"Function=SetBusBVolume&Value={volume}";
    }
    
    internal static string SetBusCVolume(int volume)
    {
        volume = Math.Clamp(volume, 0, 100);
        return $"Function=SetBusCVolume&Value={volume}";
    }
    
    internal static string SetBusDVolume(int volume)
    {
        volume = Math.Clamp(volume, 0, 100);
        return $"Function=SetBusDVolume&Value={volume}";
    }
    
    internal static string SetBusEVolume(int volume)
    {
        volume = Math.Clamp(volume, 0, 100);
        return $"Function=SetBusEVolume&Value={volume}";
    }
    
    internal static string SetBusFVolume(int volume)
    {
        volume = Math.Clamp(volume, 0, 100);
        return $"Function=SetBusFVolume&Value={volume}";
    }
    
    internal static string SetBusGVolume(int volume)
    {
        volume = Math.Clamp(volume, 0, 100);
        return $"Function=SetBusGVolume&Value={volume}";
    }
    
    internal static string SetGain(string input, double gain)
    {
        gain = Math.Clamp(gain, 0, 24);
        input = Uri.EscapeDataString(input);
        return $"Function=SetGain&Input={input}&Value={gain.ToString("0.0", CultureInfo.InvariantCulture)}";
    }
    
    internal static string SetGainChannel1(string input, double gain)
    {
        gain = Math.Clamp(gain, 0, 24);
        input = Uri.EscapeDataString(input);
        return $"Function=SetGainChannel1&Input={input}&Value={gain.ToString("0.0", CultureInfo.InvariantCulture)}";
    }
    
    internal static string SetGainChannel2(string input, double gain)
    {
        gain = Math.Clamp(gain, 0, 24);
        input = Uri.EscapeDataString(input);
        return $"Function=SetGainChannel2&Input={input}&Value={gain.ToString("0.0", CultureInfo.InvariantCulture)}";
    }
    
    internal static string SetHeadphonesVolume(int volume)
    {
        volume = Math.Clamp(volume, 0, 100);
        return $"Function=SetHeadphonesVolume&Value={volume}";
    }
    
    internal static string SetMasterVolume(int volume)
    {
        volume = Math.Clamp(volume, 0, 100);
        return $"Function=SetMasterVolume&Value={volume}";
    }
    
    internal static string SetVolume(string input, int volume)
    {
        volume = Math.Clamp(volume, 0, 100);
        input = Uri.EscapeDataString(input);
        return $"Function=SetVolume&Input={input}&Value={volume}";
    }
    
    internal static string SetVolumeBusMixer(string input, int volume)
    {
        volume = Math.Clamp(volume, 0, 100);
        input = Uri.EscapeDataString(input);
        return $"Function=SetVolumeBusMixer&Input={input}&Value={volume}";
    }
    
    internal static string SetVolumeBusMixerA(string input, int volume)
    {
        volume = Math.Clamp(volume, 0, 100);
        input = Uri.EscapeDataString(input);
        return $"Function=SetVolumeBusMixerA&Input={input}&Value={volume}";
    }
    
    internal static string SetVolumeBusMixerB(string input, int volume)
    {
        volume = Math.Clamp(volume, 0, 100);
        input = Uri.EscapeDataString(input);
        return $"Function=SetVolumeBusMixerB&Input={input}&Value={volume}";
    }
    
    internal static string SetVolumeBusMixerC(string input, int volume)
    {
        volume = Math.Clamp(volume, 0, 100);
        input = Uri.EscapeDataString(input);
        return $"Function=SetVolumeBusMixerC&Input={input}&Value={volume}";
    }
    
    internal static string SetVolumeBusMixerD(string input, int volume)
    {
        volume = Math.Clamp(volume, 0, 100);
        input = Uri.EscapeDataString(input);
        return $"Function=SetVolumeBusMixerD&Input={input}&Value={volume}";
    }
    
    internal static string SetVolumeBusMixerE(string input, int volume)
    {
        volume = Math.Clamp(volume, 0, 100);
        input = Uri.EscapeDataString(input);
        return $"Function=SetVolumeBusMixerE&Input={input}&Value={volume}";
    }
    
    internal static string SetVolumeBusMixerF(string input, int volume)
    {
        volume = Math.Clamp(volume, 0, 100);
        input = Uri.EscapeDataString(input);
        return $"Function=SetVolumeBusMixerF&Input={input}&Value={volume}";
    }
    
    internal static string SetVolumeBusMixerG(string input, int volume)
    {
        volume = Math.Clamp(volume, 0, 100);
        input = Uri.EscapeDataString(input);
        return $"Function=SetVolumeBusMixerG&Input={input}&Value={volume}";
    }
    
    internal static string SetVolumeBusMixerM(string input, int volume)
    {
        volume = Math.Clamp(volume, 0, 100);
        input = Uri.EscapeDataString(input);
        return $"Function=SetVolumeBusMixerM&Input={input}&Value={volume}";
    }
    
    internal static string SetVolumeChannel1(string input, int volume)
    {
        volume = Math.Clamp(volume, 0, 100);
        input = Uri.EscapeDataString(input);
        return $"Function=SetVolumeChannel1&Input={input}&Value={volume}";
    }
    
    internal static string SetVolumeChannel2(string input, int volume)
    {
        volume = Math.Clamp(volume, 0, 100);
        input = Uri.EscapeDataString(input);
        return $"Function=SetVolumeChannel2&Input={input}&Value={volume}";
    }
    
    internal static string SetVolumeChannelMixer(string input, int volume)
    {
        volume = Math.Clamp(volume, 0, 100);
        input = Uri.EscapeDataString(input);
        return $"Function=SetVolumeChannelMixer&Input={input}&Value={volume}";
    }
    
    //SetVolumeChannelMixer1-16
    
    internal static string SetVolumeChannelMixer1(string input, int volume)
    {
        volume = Math.Clamp(volume, 0, 100);
        input = Uri.EscapeDataString(input);
        return $"Function=SetVolumeChannelMixer1&Input={input}&Value={volume}";
    }
    
    internal static string SetVolumeChannelMixer2(string input, int volume)
    {
        volume = Math.Clamp(volume, 0, 100);
        input = Uri.EscapeDataString(input);
        return $"Function=SetVolumeChannelMixer2&Input={input}&Value={volume}";
    }
    
    internal static string SetVolumeChannelMixer3(string input, int volume)
    {
        volume = Math.Clamp(volume, 0, 100);
        input = Uri.EscapeDataString(input);
        return $"Function=SetVolumeChannelMixer3&Input={input}&Value={volume}";
    }
    
    internal static string SetVolumeChannelMixer4(string input, int volume)
    {
        volume = Math.Clamp(volume, 0, 100);
        input = Uri.EscapeDataString(input);
        return $"Function=SetVolumeChannelMixer4&Input={input}&Value={volume}";
    }
    
    internal static string SetVolumeChannelMixer5(string input, int volume)
    {
        volume = Math.Clamp(volume, 0, 100);
        input = Uri.EscapeDataString(input);
        return $"Function=SetVolumeChannelMixer5&Input={input}&Value={volume}";
    }
    
    internal static string SetVolumeChannelMixer6(string input, int volume)
    {
        volume = Math.Clamp(volume, 0, 100);
        input = Uri.EscapeDataString(input);
        return $"Function=SetVolumeChannelMixer6&Input={input}&Value={volume}";
    }
    
    internal static string SetVolumeChannelMixer7(string input, int volume)
    {
        volume = Math.Clamp(volume, 0, 100);
        input = Uri.EscapeDataString(input);
        return $"Function=SetVolumeChannelMixer7&Input={input}&Value={volume}";
    }
    
    internal static string SetVolumeChannelMixer8(string input, int volume)
    {
        volume = Math.Clamp(volume, 0, 100);
        input = Uri.EscapeDataString(input);
        return $"Function=SetVolumeChannelMixer8&Input={input}&Value={volume}";
    }
    
    internal static string SetVolumeChannelMixer9(string input, int volume)
    {
        volume = Math.Clamp(volume, 0, 100);
        input = Uri.EscapeDataString(input);
        return $"Function=SetVolumeChannelMixer9&Input={input}&Value={volume}";
    }
    
    internal static string SetVolumeChannelMixer10(string input, int volume)
    {
        volume = Math.Clamp(volume, 0, 100);
        input = Uri.EscapeDataString(input);
        return $"Function=SetVolumeChannelMixer10&Input={input}&Value={volume}";
    }
    
    internal static string SetVolumeChannelMixer11(string input, int volume)
    {
        volume = Math.Clamp(volume, 0, 100);
        input = Uri.EscapeDataString(input);
        return $"Function=SetVolumeChannelMixer11&Input={input}&Value={volume}";
    }
    
    internal static string SetVolumeChannelMixer12(string input, int volume)
    {
        volume = Math.Clamp(volume, 0, 100);
        input = Uri.EscapeDataString(input);
        return $"Function=SetVolumeChannelMixer12&Input={input}&Value={volume}";
    }
    
    internal static string SetVolumeChannelMixer13(string input, int volume)
    {
        volume = Math.Clamp(volume, 0, 100);
        input = Uri.EscapeDataString(input);
        return $"Function=SetVolumeChannelMixer13&Input={input}&Value={volume}";
    }
    
    internal static string SetVolumeChannelMixer14(string input, int volume)
    {
        volume = Math.Clamp(volume, 0, 100);
        input = Uri.EscapeDataString(input);
        return $"Function=SetVolumeChannelMixer14&Input={input}&Value={volume}";
    }
    
    internal static string SetVolumeChannelMixer15(string input, int volume)
    {
        volume = Math.Clamp(volume, 0, 100);
        input = Uri.EscapeDataString(input);
        return $"Function=SetVolumeChannelMixer15&Input={input}&Value={volume}";
    }
    
    internal static string SetVolumeChannelMixer16(string input, int volume)
    {
        volume = Math.Clamp(volume, 0, 100);
        input = Uri.EscapeDataString(input);
        return $"Function=SetVolumeChannelMixer16&Input={input}&Value={volume}";
    }
    
    internal static string SetVolumeFade(string input, int volume, int duration)
    {
        volume = Math.Clamp(volume, 0, 100);
        input = Uri.EscapeDataString(input);
        return $"Function=SetVolumeFade&Input={input}&Value={volume},{duration}";
    }
    
    internal static string Solo(string input)
    {
        input = Uri.EscapeDataString(input);
        return $"Function=Solo&Input={input}";
    }
    
    internal static string SoloAllOff()
    {
        return "Function=SoloAllOff";
    }
    
    internal static string SoloOff(string input)
    {
        input = Uri.EscapeDataString(input);
        return $"Function=SoloOff&Input={input}";
    }
    
    internal static string SoloOn(string input)
    {
        input = Uri.EscapeDataString(input);
        return $"Function=SoloOn&Input={input}";
    }

    internal static string SoloPFL()
    {
        return "Function=SoloPFL";
    }
    
    internal static string SoloPFLOff()
    {
        return "Function=SoloPFLOff";
    }
    
    internal static string SoloPFLOn()
    {
        return "Function=SoloPFLOn";
    }
    
}