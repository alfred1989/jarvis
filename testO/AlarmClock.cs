using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace testO
{
    public class AlarmClock
    {
        private static System.Timers.Timer aTimer;
        static void wav()
        {
            System.Media.SoundPlayer myPlayer;

           
                myPlayer = new System.Media.SoundPlayer();
                myPlayer.SoundLocation = @"C:\Users\pliki\Downloads\1.wav";
                myPlayer.Play();
            }
        public void allarms() { 
        SetTimer();

        //   Console.WriteLine("\nPress the Enter key to exit the application...\n");
        //  Console.WriteLine("The application started at {0:HH:mm:ss.fff}", DateTime.Now);
        Console.ReadLine();
        aTimer.Stop();
        aTimer.Dispose();

    //    Console.WriteLine("Terminating the application...");
    }

    public  void SetTimer()
    {
        // Create a timer with a two second interval.
        aTimer = new System.Timers.Timer(10000);
        // Hook up the Elapsed event for the timer. 
        aTimer.Elapsed += OnTimedEvent;
        aTimer.AutoReset = true;
        aTimer.Enabled = true;
    }

    public  void OnTimedEvent(Object source, ElapsedEventArgs e)
    {
        double godzinaBudzenia = Convert.ToDouble(DateTime.Now.ToString("hhmm"));

        Console.WriteLine(godzinaBudzenia + "     "
                          );
        double budzik = 109;

        if (budzik == godzinaBudzenia)
        {
                wav();

        }

    }



}
    }

  


  

       
            
      

