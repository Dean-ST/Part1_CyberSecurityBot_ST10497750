using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;


namespace Part1_CyberSecurityBot_ST10497750
{
    public class AudioPlayer
    {

        public static void PlayGreeting()
        {
            try
            {
                // Create sound player object
                SoundPlayer player = new SoundPlayer("greeting.wav");

                // Play audio file
                player.Play();
            }
            catch (Exception)
            {
                // Error handling if file not found
                Console.WriteLine("Audio file not found. Skipping greeting...");
            }
        }
    }
}
