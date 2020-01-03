using System;
using System.Windows.Forms;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Diagnostics;
using System.Threading;
using System.Net.Http;

namespace testO
{


    public partial class Form1 : Form
    {
        SpeechRecognitionEngine recEngine = new SpeechRecognitionEngine();
        SpeechSynthesizer synthesizer = new SpeechSynthesizer();
        System.Media.SoundPlayer myPlayer;


        public Form1()
        {
            InitializeComponent();


        }




        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Choices commands = new Choices();
       


            commands.Add(new string[] { "exit", "open google","close", "hour",
                "jarvis chrome", "win quit", "menu", 
                 "siudma","muza", "open the gate","charge state","temperature" });
            GrammarBuilder gBuilder = new GrammarBuilder();
            gBuilder.Append(commands);
            Grammar grammar = new Grammar(gBuilder);

            recEngine.LoadGrammarAsync(grammar);
            recEngine.SetInputToDefaultAudioDevice();
            recEngine.SpeechRecognized += recEngine_SpeechRecognized;

            TimeSpan godzinaTeraz = DateTime.UtcNow.ToLocalTime().TimeOfDay;

            recEngine.RecognizeAsync(RecognizeMode.Multiple);
            using var client = new HttpClient();
           
        }
        void recEngine_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {


            String time = Convert.ToString(DateTime.Now.ToString("hh,mm"));
            string godzinaBudzenia = Convert.ToString(DateTime.Now.ToString("hh,mm"));
           // int h = Convert.ToInt32(DateTime.Now.ToString("hh,mm"));
            AlarmClock alarmClock = new AlarmClock();
         
          //  if (e.Result.Text == "pobudka piata trzydziesci")
          //  {
           //     synthesizer.SpeakAsync("ustawiono");
            //    alarmClock.allarms();
           // }
            
            switch (e.Result.Text)
                
            {
                case "jarvis":
                    synthesizer.SpeakAsync("w czym moge pomuc");
                 //     myPlayer = new System.Media.SoundPlayer();
                   // myPlayer.SoundLocation = @"C:\Users\pliki\Downloads\1.wav";
                    //myPlayer.Play();

                    break;
                case "jarvis chrome":
                    synthesizer.SpeakAsync("otwieram google");
                    string google = "http://www.googel.com";
                    // System.Diagnostics.Process.Start(target);
                    Process myProcess = Process.Start(google);
                    break;
                case "exit":
                    System.Diagnostics.Process.Start("cmd.exe", @"/c C:\Users\pliki\source\repos\testO\test.bat");
                    synthesizer.SpeakAsync("zamykanie programu");
                    break;

                case "open the gate":
                    //   string gate = "................................";https://remoteme.org/ //
                    Process gateOpen = Process.Start(gate);
                    synthesizer.SpeakAsync("otiweranie bramy");
                    Thread.Sleep(4000);
                      System.Diagnostics.Process.Start("cmd.exe", @"/c C:\Users\pliki\source\repos\testO\test.bat");
                    break;
                case "close":
                    //  string gateClose = ".........................."; API z https://remoteme.org/
                    Process gatre_Close = Process.Start(gateClose);

                    synthesizer.SpeakAsync("zamykanie bramy");
                    Thread.Sleep(4000);
                     System.Diagnostics.Process.Start("cmd.exe", @"/c C:\Users\pliki\source\repos\testO\test.bat");
                    break;
                case "hour":


                    synthesizer.SpeakAsync(time);
                    break;

                case "win quit":
                    System.Diagnostics.Process.Start("cmd.exe", @"/c C:\Users\pliki\source\repos\testO\exit.bat");
                    synthesizer.SpeakAsync("zamykanie programu");
                    break;

              //  case "budzik":


                   // synthesizer.SpeakAsync(time);
                    break;
                case "muza":
                    synthesizer.SpeakAsync("otwieram google");
                    string radio = "https://player.radiozet.pl";
                    // System.Diagnostics.Process.Start(target);
                    Process myProcessR = Process.Start(radio);
                    break;

                case "charge state":
                    conditionOfTheContainer_CO co = new conditionOfTheContainer_CO();
                    co.C_O();
                    synthesizer.SpeakAsync(co.C_O() + "percent");
                    break;
                case "temperature":
                    conditionOfTheContainer_CO temp = new conditionOfTheContainer_CO();
                    temp.temp();
                    synthesizer.SpeakAsync(temp.temp()+ "degrees");
                    break;
                case "menu":
                    synthesizer.SpeakAsync(" ");

                    break;

            }


            }
        }
    }


        
 

       
    