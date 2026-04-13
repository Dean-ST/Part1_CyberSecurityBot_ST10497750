using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1_CyberSecurityBot_ST10497750
{
    public class ChatBot
    {

        public void StartChat()
        {
            while (true)
            {
                ShowMenu();

                Console.Write("\nEnter choice (1-10): ");
                string input = Console.ReadLine();

                // Input validation
                if (!int.TryParse(input, out int choice))
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Cybersecurity is protecting systems and data from various attacks.");
                        break;

                    case 2:
                        Console.WriteLine("Phishing is a scam where attackers trick you into giving personal info.");
                        break;

                    case 3:
                        Console.WriteLine("Use strong passwords with uppercase, lowercase, numbers, and symbols.");
                        break;

                    case 4:
                        Console.WriteLine("Avoid clicking suspicious links in emails.");
                        break;

                    case 5:
                        Console.WriteLine("Always keep your software updated.");
                        break;

                    case 6:
                        Console.WriteLine("Use antivirus software to protect your system.");
                        break;

                    case 7:
                        Console.WriteLine("Do not share personal information online.");
                        break;

                    case 8:
                        Console.WriteLine("Use two-factor authentication for extra security.");
                        break;

                    case 9:
                        Console.WriteLine("Public Wi-Fi can be unsafe. Use a VPN if possible.");
                        break;

                    case 10:
                        Console.WriteLine("Goodbye! Stay safe online. We introduce you to more updates and questions." +
                            "");
                        return;

                    default:
                        Console.WriteLine("Please choose a number between 1 and 10.");
                        break;
                }
            }
        }



        private void ShowMenu()
        {

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Select a cybersecurity topic below:");
            Console.ResetColor();

            Console.WriteLine("\n===== CYBERSECURITY MENU =====");
            Console.WriteLine("1. What is cybersecurity?");
            Console.WriteLine("2. What is phishing?");
            Console.WriteLine("3. How to create a strong password?");
            Console.WriteLine("4. How to avoid scams?");
            Console.WriteLine("5. Why update software?");
            Console.WriteLine("6. What is antivirus?");
            Console.WriteLine("7. Why protect personal info?");
            Console.WriteLine("8. What is two-factor authentication?");
            Console.WriteLine("9. Is public Wi-Fi safe?");
            Console.WriteLine("10. Exit");
        }
    }
}

