using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

namespace ConsoleOS
{
	class MainClass
	{
	   public static void Main (string[] args)
		{
			Console.WriteLine ("Hello User!");//information about system;

			Console.CursorVisible = false; //Progressbar Animation
			Console.SetCursorPosition (1, 1);

			for (int i = 0; i <= 100; i++) 
			{
				for (int y = 0; y < i; y++) 
				{
					Console.Write ("");
				}

				Console.Write (i + "/100%");
				Console.SetCursorPosition (1, 1);
				System.Threading.Thread.Sleep (100);
			}


			Console.ReadLine ();

			Console.Clear ();

			/*Console.Write ("OS Name: ");
			Console.WriteLine (System.Environment.OSVersion.Platform);
			Console.Write ("ServicePack: ");
			Console.WriteLine (System.Environment.OSVersion.ServicePack);
			Console.Write ("Version: ");
			Console.WriteLine (System.Environment.OSVersion.Version);
			Console.WriteLine (System.Environment.OSVersion.VersionString);*/

			/*Console.WriteLine ("Enter ABOUT or about");
			string wert = Console.ReadLine ();
			Console.WriteLine ("This is my operating system. It's created on 28.06.2016" + wert);
			Console.Read ();*/

			//Console.WriteLine ("Press the Enter button");

			//Console.ReadKey ();

			/*ConsoleKeyInfo cki;
			Console.TreatControlCAsInput = true;
			Console.WriteLine("Press the a button key to open browser: \n");
			do 
			{
				cki = Console.ReadKey ();
				Console.Write (" --- You pressed ");
				if ((cki.Modifiers & ConsoleModifiers.Shift) != 0) Console.Write ("SHIFT+");
				Console.WriteLine (cki.Key.ToString ());
				Process.Start ("http://www.google.com");

			} 
			while(cki.Key != ConsoleKey.Escape);*/

			//Process.Start ("http://www.google.com"); //open webbrowser

			Console.WriteLine ("This is a general menu.\nPlese Type a command \n> ABOUT \n> SETTINGS \n> SHUTDOWN \n> HELP \n> ENTHERNET \n> SYSTEM \n> LOGIN \n> CALCULATOR \n> GAME"); //start to type commands
			string command = Console.ReadLine ();
			{
				Console.Clear ();

				if (command == "settings") //settings
				{
					Console.WriteLine ("\n> CHANGE COLOR \n> CHANGE BRIGHTNESS \n> CHANGE SPEAKER");
					string command1 = Console.ReadLine ();
					{
						Console.Clear ();

						if (command1 == "color") 
						{
							Console.BackgroundColor = ConsoleColor.White;
						}

						if (command1 == "brightness") 
						{
							Console.WriteLine ("Hello world");
						} 

						else if (command1 == "speaker") 
						{

							//Console.WriteLine ("Hello world")
							Console.Beep(300, 500);
							Thread.Sleep(50);
							Console.Beep(300, 500);
							Thread.Sleep(50);
							Console.Beep(300, 500);
							Thread.Sleep(50);
							Console.Beep(250, 500);
							Thread.Sleep(50);
							Console.Beep(350, 250);
							Console.Beep(300, 500);
							Thread.Sleep(50);
							Console.Beep(250, 500);
							Thread.Sleep(50);
							Console.Beep(350, 250);
							Console.Beep(300, 500);
							Thread.Sleep(50);
						}
					}
				}

				if (command == "about") //about
				{
					Console.WriteLine ("This is my operating system. It's created on 28.06.2016");
					Console.Read ();
				} 

				if (command == "help") //help
				{
					Console.WriteLine ("Hello user. There you can write help, about shutdown or enthernet. If you write about you will show information. If you write enthernet the webbrowser wil open. If you write system you will get information. If you write login you can login to our system. If you write shutdown this console will shutdown");
					Console.Read ();
				}

				if (command == "enthernet") //enthernet
				{
					Process.Start ("http://www.google.com");

				}

				if (command == "system") //system
				{
					Console.WriteLine ("Hello User!");//information about system
					Console.Write ("OS Name: ");
					Console.WriteLine (System.Environment.OSVersion.Platform);
					Console.Write ("ServicePack: ");
					Console.WriteLine (System.Environment.OSVersion.ServicePack);
					Console.Write ("Version: ");
					Console.WriteLine (System.Environment.OSVersion.Version);
					Console.WriteLine (System.Environment.OSVersion.VersionString);

					Console.ReadKey ();
				}

				if (command == "login") //login
				{
					string username, password = string.Empty;

					Console.Write ("Enter a username: ");
					username = Console.ReadLine ();
					Console.Write ("Enter a password: ");
					password = Console.ReadLine ();

					using (StreamWriter sw = new StreamWriter(File.Create("Nautilus:Домашняя папка\\Документы\\1.txt"))) 
					{
						sw.Write (username);
						sw.Write (password);
						sw.Close ();
					}

					Console.WriteLine ("Done...");
					Console.Read ();

					Console.WriteLine ("Enter your name: ");//here to introduce yourself
					string name = Console.ReadLine ();

					Console.WriteLine ("Hello " + name);
					Console.Read ();

					Console.WriteLine ("How are you? ");
					string question1 = Console.ReadLine ();

					Console.WriteLine ("It is " + question1);
					Console.Read ();
				}

				if (command == "calculator") //start to calculator
				{
					float x;
					float y;

					Console.WriteLine ("Enter first number: ");
					x = Convert.ToInt64(Console.ReadLine());

					Console.WriteLine ("Enter second number: ");
					y = Convert.ToInt64(Console.ReadLine());

					float c = x + y;
					Console.WriteLine ("Amount is: ");
					Console.WriteLine (c);

					float e = x - y;
					Console.WriteLine ("Subtraction is: ");
					Console.WriteLine (e);

					float w = x * y;
					Console.WriteLine ("Multiplication is: ");
					Console.WriteLine (w);

					double q = x / y;
					Console.WriteLine ("Division is: ");
					Console.WriteLine (q);

					double b = Math.Sqrt (x);
					Console.WriteLine ("Square is: ");
					Console.WriteLine (b);

					double j = Math.Sqrt (y);
					Console.WriteLine ("Square is: ");
					Console.WriteLine (j);

					if (x < y) 
					{
						Console.WriteLine ("X < Y");
					} 

					else 
					{
						Console.WriteLine ("X > Y");
					}

					Console.WriteLine ("Thanks!!!");
				}

				if (command == "game") 
				{
					Console.WriteLine ("\n> GAME1 \n> GAME2");

					string command2 = Console.ReadLine ();
					{
						Console.Clear ();

						if (command2 == "game1") { //start to game
							string num1;
							string num2;

							Console.WriteLine ("Pick the number: ");
							num1 = Console.ReadLine ();

							Console.WriteLine ("Guess the number: ");
							num2 = Console.ReadLine ();

							if (num1 == num2) {
								Console.WriteLine ("You are right");
							} else {
								Console.WriteLine ("You loose");
							}

							Console.Read ();
						}

						if (command2 == "game2") { //starts game1
							//Ints:
							int correct = 0;
							int Player_One_Handed = 0;
							int Player_Two_Handed = 0;
							int Player_Ranged_Weapon = 0;
							int Player_Magic = 0;
							int Arraycount = 0;
							int Player_Attack_Type = 0;
							int Player_One_Weapon_Damage = 2;
							int Player_Two_Weapon_Damage = 2;
							int Player_Range_Weapon_Damage = 2;
							int Player_Magic_Damage = 2;
							int Player_Health_Points = 20;
							int Player_Mana_Points = 12;
							int Enemy_Health_Points;
							int Enemy_Maximum_Damage;
							int Player_Inventory_Money = 0;
							int Player_Inventory_Experience = 0;
							int Quest_Reward_EXP;
							int Quest_Reward_Gold;
							int Player_Quest_Progress = 0;
							int Player_Quest_Goal;
							int Player_EXP = 0;

							//Strings:
							string Player_Gender;
							string Player_Race;
							string Player_Class;
							string[] Inventory = new string[20];
							string Input;
							string Enemy_Name;
							string Player_Quest = " ";
							string Quest_Accepted;
							string Player_Quest_Enemy;



							//Character Creation:
							do {
								Console.Clear ();
								Console.WriteLine ("Please choose a gender as below:");
								Console.WriteLine ("Male / Female");
								Player_Gender = Console.ReadLine ().ToUpper ();
								if (Player_Gender == "MALE" || Player_Gender == "FEMALE") {
									correct = 1;
								} else {
								}
							} while(correct == 0);
							correct = 0;




							//Race Creation:
							do {
								Console.Clear ();
								Console.WriteLine ("Please choose a race as below:");
								Console.WriteLine ("Human");
								Console.WriteLine ("Dwarf");
								Console.WriteLine ("Elf");
								Console.WriteLine ("Orc");
								Console.WriteLine ("Your Choice:");
								Player_Race = Console.ReadLine ().ToUpper ();
								if (Player_Race == "HUMAN") {
									Console.WriteLine ("This race gives a bonus to the following stats:");
									Console.WriteLine ("One Handed Weapons. 1 Point");
									Console.WriteLine ("Two Handed Weapons. 1 Point");
									Console.WriteLine ("Ranged Weapons. 1 Point");
									Console.WriteLine ("Magical Attack. 1 Point");
									Console.WriteLine ("Is this the race you wish to play? Enter Yes/No Below:");
									Input = Console.ReadLine ().ToUpper ();
									if (Input == "YES") {
										correct = 1;
									}
									if (Input == "NO") {
										correct = 0;
									}
								} 

								if (Player_Race == "DWARF") {
									Console.WriteLine ("This race gives a bonus to the following stats:");
									Console.WriteLine ("One Handed Weapons. 1 Point");
									Console.WriteLine ("Two Handed Weapons. 2 Point");
									Console.WriteLine ("Ranged Weapons. 1 Point");
									Console.WriteLine ("Magical Attack. 0 Point");
									Console.WriteLine ("Is this the race you wish to play? Enter Yes/No Below:");
									Input = Console.ReadLine ().ToUpper ();
									if (Input == "YES") {
										correct = 1;
									}
									if (Input == "NO") {
										correct = 0;
									}
								} 

								if (Player_Race == "ELF") {
									Console.WriteLine ("This race gives a bonus to the following stats:");
									Console.WriteLine ("One Handed Weapons. 0 Point");
									Console.WriteLine ("Two Handed Weapons. 1 Point");
									Console.WriteLine ("Ranged Weapons. 2 Point");
									Console.WriteLine ("Magical Attack. 1 Point");
									Console.WriteLine ("Is this the race you wish to play? Enter Yes/No Below:");
									Input = Console.ReadLine ().ToUpper ();
									if (Input == "YES") {
										correct = 1;
									}
									if (Input == "NO") {
										correct = 0;
									}
								} 

								if (Player_Race == "ORC") {
									Console.WriteLine ("This race gives a bonus to the following stats:");
									Console.WriteLine ("One Handed Weapons. 2 Point");
									Console.WriteLine ("Two Handed Weapons. 2 Point");
									Console.WriteLine ("Ranged Weapons. 0 Point");
									Console.WriteLine ("Magical Attack. 0 Point");
									Console.WriteLine ("Is this the race you wish to play? Enter Yes/No Below:");
									Input = Console.ReadLine ().ToUpper ();
									if (Input == "YES") {
										correct = 1;
									}
									if (Input == "NO") {
										correct = 0;
									}
								} 
							} while(correct == 0);
							correct = 0;




							//Class Creation:
							do {
								Console.Clear ();
								Console.WriteLine ("Please choose a class as below:");
								Console.WriteLine ("Warrior");
								Console.WriteLine ("Hunter");
								Console.WriteLine ("Mage");
								Console.WriteLine ("Thief");
								Console.WriteLine ("Your Choice:");
								Player_Class = Console.ReadLine ().ToUpper ();
								if (Player_Class == "WARRIOR") {
									Console.WriteLine ("This class gives a bonus to the following stats:");
									Console.WriteLine ("One Handed Weapons. 2 Point");
									Console.WriteLine ("Two Handed Weapons. 2 Point");
									Console.WriteLine ("Ranged Weapons. 0 Point");
									Console.WriteLine ("Magical Attack. 0 Point");
									Console.WriteLine ("Is this the class you wish to play? Enter Yes/No Below:");
									Input = Console.ReadLine ().ToUpper ();
									if (Input == "YES") {
										correct = 1;
									}
									if (Input == "NO") {
										correct = 0;
									}
								} 
								if (Player_Class == "HUNTER") {
									Console.WriteLine ("This class gives a bonus to the following stats:");
									Console.WriteLine ("One Handed Weapons. 1 Point");
									Console.WriteLine ("Two Handed Weapons. 1 Point");
									Console.WriteLine ("Ranged Weapons. 2 Point");
									Console.WriteLine ("Magical Attack. 0 Point");
									Console.WriteLine ("Is this the class you wish to play? Enter Yes/No Below:");
									Input = Console.ReadLine ().ToUpper ();
									if (Input == "YES") {
										correct = 1;
									}
									if (Input == "NO") {
										correct = 0;
									}
								} 
								if (Player_Class == "MAGE") {
									Console.WriteLine ("This class gives a bonus to the following stats:");
									Console.WriteLine ("One Handed Weapons. 1 Point");
									Console.WriteLine ("Two Handed Weapons. 0 Point");
									Console.WriteLine ("Ranged Weapons. 1 Point");
									Console.WriteLine ("Magical Attack. 2 Point");
									Console.WriteLine ("Is this the class you wish to play? Enter Yes/No Below:");
									Input = Console.ReadLine ().ToUpper ();
									if (Input == "YES") {
										correct = 1;
									}
									if (Input == "NO") {
										correct = 0;
									}
								} 
								if (Player_Class == "THIEF") {
									Console.WriteLine ("This class gives a bonus to the following stats:");
									Console.WriteLine ("One Handed Weapons. 2 Point");
									Console.WriteLine ("Two Handed Weapons. 0 Point");
									Console.WriteLine ("Ranged Weapons. 1 Point");
									Console.WriteLine ("Magical Attack. 1 Point");
									Console.WriteLine ("Is this the class you wish to play? Enter Yes/No Below:");
									Input = Console.ReadLine ().ToUpper ();
									if (Input == "YES") {
										correct = 1;
									}
									if (Input == "NO") {
										correct = 0;
									}
								} else {
								}
							} while(correct == 0);
							correct = 0;


							//Bonuses:
							//Race Bonus:
							if (Player_Race == "HUMAN") {
								Player_One_Handed++;  
								Player_Two_Handed++; 
								Player_Ranged_Weapon++; 
								Player_Magic++;
							}
							if (Player_Race == "DWARF") {
								Player_One_Handed++;  
								Player_Two_Handed = Player_Two_Handed + 2; 
								Player_Ranged_Weapon++; 
							}
							if (Player_Race == "ELF") {
								Player_One_Handed++;  
								Player_Ranged_Weapon = Player_Ranged_Weapon + 2;
								Player_Magic++;
							}
							if (Player_Race == "ORC") {
								Player_One_Handed = Player_One_Handed + 2; 
								Player_Two_Handed = Player_Two_Handed + 2; 
							}

							//Class Bonus:
							if (Player_Class == "WARRIOR") {
								Player_One_Handed = Player_One_Handed + 2;
								Player_Two_Handed = Player_Two_Handed + 2;
							}
							if (Player_Class == "HUNTER") {
								Player_One_Handed++;  
								Player_Two_Handed++; 
								Player_Ranged_Weapon = Player_Ranged_Weapon + 2; 
							}
							if (Player_Class == "MAGE") {
								Player_One_Handed++;  
								Player_Ranged_Weapon++; 
								Player_Magic = Player_Magic + 2;
							}
							if (Player_Class == "THIEF") {
								Player_One_Handed = Player_One_Handed + 2;
								Player_Ranged_Weapon++; 
								Player_Magic++;
							}


							//Player Description, Writeout
							Console.Clear ();
							Console.WriteLine ("Your Full Character Description, is:");
							Console.WriteLine ("A {0} {1} {2}", Player_Gender, Player_Race, Player_Class);
							Console.WriteLine ("One Handed Weapon Skill Points: {0}", Player_One_Handed);
							Console.WriteLine ("Two Handed Weapon Skill Points: {0}", Player_Two_Handed);
							Console.WriteLine ("Ranged Weapon Skill Points: {0}", Player_Ranged_Weapon);
							Console.WriteLine ("Magical Attack Skill Points: {0}", Player_Magic);
							Console.ReadLine ();







							Inventory [0] = "a";
							Inventory [1] = "b";
							Inventory [2] = "snails";

							Console.Clear ();
							Console.WriteLine ("Inventory Test: type inventory below"); 
							Input = Console.ReadLine ().ToUpper ();
							//Inventory System:
							if (Input == "INVENTORY" || Input == "INV") {
								Console.Clear ();
								Console.WriteLine ("Your Inventory Contains:");
								for (Arraycount = 0; Arraycount < 20; Arraycount++) {
									int inventory_possition = Arraycount + 1;
									Console.SetCursorPosition (0, inventory_possition);
									Console.WriteLine ("{0}", Inventory [Arraycount]);
								}
							} else {
							}





							//Enemy Declair System:
							Enemy_Name = "Rat";
							Enemy_Health_Points = 12;
							Enemy_Maximum_Damage = 2;

							//Combat System:

							do {
								correct = 0;
								Console.Clear ();
								Console.WriteLine ("Your Health is at {0} Points, Your Mana is at {1} Points", Player_Health_Points, Player_Mana_Points);
								Console.WriteLine ("The {0}s Healt is at {1} Points", Enemy_Name, Enemy_Health_Points);
								Console.WriteLine ("Enter the number for the type of attack that you wish to perform:");
								Console.WriteLine ("1. One Handed Attack");
								Console.WriteLine ("2. Two Handed Attack");
								Console.WriteLine ("3. Ranged Weapon Attack");
								Console.WriteLine ("4. Magical Attack");
								Player_Attack_Type = Convert.ToInt32 (Console.ReadLine ());
								if (Player_Attack_Type == 1) {
									Random Damage_Roll = new Random ();
									int Random_Damage_Roll = Damage_Roll.Next (0, Player_One_Weapon_Damage);
									Console.WriteLine ("{0}", Random_Damage_Roll);
									Random Skill_Point_Roll = new Random ();
									int Skill_Point_Outcome = Skill_Point_Roll.Next (0, 11);
									if (Skill_Point_Outcome > 6 && Random_Damage_Roll > 0) {
										Random_Damage_Roll = Random_Damage_Roll + Player_One_Handed;
										Console.WriteLine ("You did a critical hit, and added {0} Skill points of damage", Player_One_Handed);
									} else {
									}
									Console.WriteLine ("You did {0} Damage to the {1}", Random_Damage_Roll, Enemy_Name);
									Enemy_Health_Points = Enemy_Health_Points - Random_Damage_Roll;
								}
								if (Player_Attack_Type == 2) {
									Random Damage_Roll = new Random ();
									int Random_Damage_Roll = Damage_Roll.Next (0, Player_Two_Handed);
									Console.WriteLine ("{0}", Random_Damage_Roll);
									Random Skill_Point_Roll = new Random ();
									int Skill_Point_Outcome = Skill_Point_Roll.Next (0, 11);
									if (Skill_Point_Outcome > 6 && Random_Damage_Roll > 0) {
										Random_Damage_Roll = Random_Damage_Roll + Player_Two_Handed;
										Console.WriteLine ("You did a critical hit, and added {0} Skill points of damage", Player_Two_Handed);
									} else {
									}

									Console.WriteLine ("You did {0} Damage to the {1}", Random_Damage_Roll, Enemy_Name);
									Enemy_Health_Points = Enemy_Health_Points - Random_Damage_Roll;
								}
								if (Player_Attack_Type == 3) {
									Random Damage_Roll = new Random ();
									int Random_Damage_Roll = Damage_Roll.Next (0, Player_Ranged_Weapon);
									Console.WriteLine ("{0}", Random_Damage_Roll);
									Random Skill_Point_Roll = new Random ();
									int Skill_Point_Outcome = Skill_Point_Roll.Next (0, 11);
									if (Skill_Point_Outcome > 6 && Random_Damage_Roll > 0) {
										Random_Damage_Roll = Random_Damage_Roll + Player_Ranged_Weapon;
										Console.WriteLine ("You did a critical hit, and added {0} Skill points of damage", Player_Ranged_Weapon);
									} else {
									}

									Console.WriteLine ("You did {0} Damage to the {1}", Random_Damage_Roll, Enemy_Name);
									Enemy_Health_Points = Enemy_Health_Points - Random_Damage_Roll;
								}
								if (Player_Attack_Type == 4) {
									Random Damage_Roll = new Random ();
									int Random_Damage_Roll = Damage_Roll.Next (0, Player_Magic);
									Console.WriteLine ("{0}", Random_Damage_Roll);
									Random Skill_Point_Roll = new Random ();
									int Skill_Point_Outcome = Skill_Point_Roll.Next (0, 11);
									if (Skill_Point_Outcome > 6 && Random_Damage_Roll > 0) {
										Random_Damage_Roll = Random_Damage_Roll + Player_Magic;
										Console.WriteLine ("You did a critical hit, and added {0} Skill points of damage", Player_Magic);
									} else {
									}

									Console.WriteLine ("You did {0} Damage to the {1}", Random_Damage_Roll, Enemy_Name);
									Enemy_Health_Points = Enemy_Health_Points - Random_Damage_Roll;
								} else {
								}
								if (Enemy_Health_Points > 0) {
									Random Enemy_Damage_Roll = new Random ();
									int Random_Enemy_Damage_Roll = Enemy_Damage_Roll.Next (0, Enemy_Maximum_Damage);
									Console.WriteLine ("The {0} Strikes back, and deal {1} Points of Damage", Enemy_Name, Random_Enemy_Damage_Roll);
									Player_Health_Points = Player_Health_Points - Random_Enemy_Damage_Roll;
									Console.ReadLine ();
								} else {
								}
							} while(Player_Health_Points > 0 && Enemy_Health_Points > 0);
							Console.Clear ();
							if (Enemy_Health_Points < 0) {
								Enemy_Health_Points = 0;
							}
							if (Player_Health_Points < 0) {
								Player_Health_Points = 0;
							}
							Console.WriteLine ("Your Health is at {0} Points, Your Mana is at {1} Points", Player_Health_Points, Player_Mana_Points);
							Console.WriteLine ("The {0}s Healt is at {1} Points", Enemy_Name, Enemy_Health_Points);
							Console.WriteLine ("Enter the number for the type of attack that you wish to perform:");
							Console.WriteLine ("1. One Handed Attack");
							Console.WriteLine ("2. Two Handed Attack");
							Console.WriteLine ("3. Ranged Weapon Attack");
							Console.WriteLine ("4. Magical Attack");
							if (Enemy_Health_Points > 0) {
								Console.WriteLine ("");
								Console.WriteLine (" - You lost the battle.");
								Console.ReadLine ();
							}
							if (Player_Health_Points > 0) {
								Console.WriteLine ("");
								Console.WriteLine (" - You won the battle.");
								Console.ReadLine ();
							}




							//Quest giving system:
							Quest_Reward_EXP = 20;
							Quest_Reward_Gold = 50;
							Player_Quest_Goal = 3;
							Player_Quest_Enemy = "Rats";

							do {
								correct = 0;
								Console.Clear ();
								if (Player_Quest != " ") {
									Console.WriteLine ("You have to finish your current quest, in orden to get a new one.");
									correct = 1;
								}

								if (Player_Quest == " ") {
									Console.WriteLine ("I would gladly pay you to kill the 3 rats, thats annoying me, out on my fields.");
									Console.WriteLine ("Reward: {0} Gold, and {1} EXP", Quest_Reward_Gold, Quest_Reward_EXP);
									Console.WriteLine ("Accept Yes/No:");
									Input = Console.ReadLine ().ToUpper ();
									if (Input == "NO") {
										correct = 1;
										Quest_Accepted = "NO";
									}
									if (Input == "YES") {
										Console.WriteLine ("The quest has been accepted.");
										Player_Quest = "The farmer would gladly pay you 50 and give you 20 EXP, to rid his fields of the 3 rats";
										correct = 1;
										Quest_Accepted = "YES";
									}
								}


							} while(correct == 0);
							Console.ReadLine ();






							//Menu Writeout
							do {
								correct = 0;
								Console.Clear ();
								Console.WriteLine ("Enter Quest, to see your current quest");
								Console.WriteLine ("Enter Inventory, to see your Inventory content");
								Console.WriteLine ("Enter Status, to see in detail how your character is doing");
								Console.WriteLine ("Enter Exit, to quit the menu");
								Input = Console.ReadLine ().ToUpper ();
								if (Input == "QUEST" && Player_Quest != " ") {
									do {
										Console.Clear ();
										Console.WriteLine (Player_Quest);
										Console.WriteLine ("Progress: {0}/{1} {2}", Player_Quest_Progress, Player_Quest_Goal, Player_Quest_Enemy);
										Console.WriteLine ("< Back");
										Input = Console.ReadLine ().ToUpper ();
										if (Input == "BACK") {
											correct = 1;
										}
										if (Input != "BACK") {
										}
									} while(correct == 0);
								}
								if (Input == "QUEST" && Player_Quest == " ") {
									do {
										Console.Clear ();
										Console.WriteLine ("You don not have any active quests at the moment");
										Console.WriteLine ("< back");
										Input = Console.ReadLine ().ToUpper ();
										if (Input == "BACK") {
											correct = 1;
										}
										if (Input != "BACK") {
										}
									} while(correct == 0);
								}
								if (Input == "INVENTORY" || Input == "INV") {
									do {
										Console.Clear ();
										Console.WriteLine ("Your Inventory Contains:");
										for (Arraycount = 0; Arraycount < 20; Arraycount++) {
											int inventory_possition = Arraycount + 1;
											Console.SetCursorPosition (0, inventory_possition);
											Console.WriteLine ("{0}", Inventory [Arraycount]);
										}
										Console.WriteLine ("< Back");
										Input = Console.ReadLine ().ToUpper ();
										if (Input == "BACK") {
											correct = 1;
										}
										if (Input != "BACK") {
											correct = 0;
										}
									} while(correct == 0);

								}
								if (Input == "STATUS" || Input == "STAT") {
									do {
										Console.Clear ();
										Console.WriteLine ("You character is:");
										Console.WriteLine ("A {0} {1} {2}", Player_Gender, Player_Race, Player_Class);
										Console.WriteLine ("One Handed Weapon Skill Points: {0}", Player_One_Handed);
										Console.WriteLine ("Two Handed Weapon Skill Points: {0}", Player_Two_Handed);
										Console.WriteLine ("Ranged Weapon Skill Points: {0}", Player_Ranged_Weapon);
										Console.WriteLine ("Magical Attack Skill Points: {0}", Player_Magic);
										Console.WriteLine ("{0} Health Points, {1} Mana Points, {2} Experience Points", Player_Health_Points, Player_Mana_Points, Player_EXP);
										Console.WriteLine ("< Back");
										Input = Console.ReadLine ().ToUpper ();
										if (Input == "BACK") {
											correct = 1;
										}
										if (Input != "BACK") {
											correct = 0;
										}
									} while(correct == 0);
								}
								if (Input == "EXIT") {
									correct = 2;
								} else {
								}
							} while(correct != 2);
					










							Console.ReadLine ();
						}// ends game1
					}
				}

				else if (command == "shutdown") // start to exit
				{
					Console.WriteLine ("It is shutdown...");
					System.Environment.Exit (0);
					Console.Read ();
				}
			}

			/*Console.WriteLine ("Now we create a new user");//creating something like login

			string username, password = string.Empty;

			Console.Write ("Enter a username: ");
			username = Console.ReadLine ();
			Console.Write ("Enter a password: ");
			password = Console.ReadLine ();

			using (StreamWriter sw = new StreamWriter(File.Create("Nautilus:Домашняя папка\\Документы\\1.txt"))) 
			{
				sw.Write (username);
				sw.Write (password);
				sw.Close ();
			}

			Console.WriteLine ("Done...");
			Console.Read ();

			Console.WriteLine ("Enter your name: ");//here to introduce yourself
			string name = Console.ReadLine ();

			Console.WriteLine ("Hello " + name);
			Console.Read ();

			Console.WriteLine ("How are you? ");
			string question1 = Console.ReadLine ();

			Console.WriteLine ("It is " + question1);
			Console.Read ();*/
			Console.ReadLine ();
			Console.ReadLine ();
			Console.ReadLine ();
			Console.ReadLine ();
			Console.ReadLine ();
			Console.ReadLine ();
			Console.ReadLine ();
			Console.ReadLine ();
			Console.ReadLine ();
			Console.ReadLine ();
			Console.ReadLine ();
			Console.ReadLine ();
		}

		/*public static void command(string[] args)
		{
			Console.WriteLine ("Plese Type a command");
			string command = Console.ReadLine ();
			{
				if (command == "help") 
				{
					Console.WriteLine ("This is my operating system. It's created on 28.06.2016");
					Console.Read ();
				} 
				else if (command == "shutdown") 
				{
					Console.WriteLine ("It is shutdown...");
					Console.Read ();
				}
			}
		}

		public static void Smain(string[] args)
		{
			Console.WriteLine ("The end...");
		}*/

	}
}
