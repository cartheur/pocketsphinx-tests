using Pocketsphinx;
using Cartheur.Animals.Utilities;

namespace Cartheur.Animals.Tests
{
    public class PocketSphinxTests
    {
        Decoder decoder { get; set; }
        Config Configuration { get; set; }
        FrontEnd Front { get; set; }

        public void SetupDecoderTest()
        {
            byte[] data = File.ReadAllBytes(@"c:\aeonWorkingDirectory\aiventure\aiventure-aeon\core-desktop-mono\2\Cartheur.Animals.Tests\bin\Debug\data\rapn-tap.wav");

            Logging.WriteLog("Initializing decoder.", Logging.LogType.Information, Logging.LogCaller.TestFramework);
            Configuration = Decoder.DefaultConfig();

            //c.SetString ("-rawlogdir", "/tmp");

            Configuration.SetString("-hmm", @"c:\pocketsphinx\model\hmm\");
            Configuration.SetString("-dict", @"c:\pocketsphinx\model\cmudict-en-us.dict");
            Configuration.SetString("-lm", @"c:\pocketsphinx\model\en-us.lm.bin");

            Configuration.SetString("-keyphrase", "hello computer");
            Configuration.SetFloat("-kws_threshold", 1e-30);
            Configuration.SetInt("-silentLimit", 1);

            Configuration.SetFloat("-samprate", 44100);
            Configuration.SetInt("-nfft", 2048);

            decoder = new Decoder(Configuration);
            decoder.StartUtt();
            decoder.ProcessRaw(data, data.Length, false, false);
            decoder.EndUtt();
            System.Console.WriteLine("Result is '{0}'", decoder.Hyp().Hypstr);
            Logging.WriteLog("Done initializing decoder.", Logging.LogType.Information, Logging.LogCaller.TestFramework);
        }

        //[TestCase("rapn-tap.wav")]
        //[TestCase("005.wav")]
        //[TestCase("statement.wav")]// not so good
        public void TranscribeAudioTest(string file)
        {
            Config c = Decoder.DefaultConfig();
            c.SetString("-hmm", @"c:\pocketsphinx\model\hmm\");
            c.SetString("-lm", @"c:\pocketsphinx\model\en-us.lm.bin");
            c.SetString("-dict", @"c:\pocketsphinx\model\cmudict-en-us.dict");
            Decoder d = new Decoder(c);

            byte[] data = File.ReadAllBytes(@"c:\aeonWorkingDirectory\aiventure\aiventure-aeon\core-desktop\windows\Cartheur.Animals.Tests\bin\Debug\data\" + file);
            d.StartUtt();
            d.ProcessRaw(data, data.Length, false, false);
            d.EndUtt();
            

            System.Console.WriteLine("Result is '{0}'", d.Hyp().Hypstr);

            //foreach (Segment s in d.Seg())
            //{
            //    System.Console.WriteLine(s);
            //}
        }

        public void SpeechRecognizerTest()
        {
            SetConfiguration();
            decoder = new Decoder(Configuration);
            decoder.StartStream();
            
        }

        public void SetConfiguration()
        {
            Configuration = Decoder.DefaultConfig();
            Configuration.SetString("-hmm", @"c:\pocketsphinx\model\hmm\");
            Configuration.SetString("-dict", @"c:\pocketsphinx\model\cmudict-en-us.dict");
            Configuration.SetString("-lm", @"c:\pocketsphinx\model\en-us.lm.bin");

            Configuration.SetString("-keyphrase", "hello computer");
            Configuration.SetFloat("-kws_threshold", 1e-30);

            Configuration.SetFloat("-samprate", 44100);
            Configuration.SetInt("-nfft", 2048);
        }
    }
}
