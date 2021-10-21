using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace Najlepsi_strzelcy
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private static ScorersDatabase database = new ScorersDatabase();



		private static void WriteJson(object obj)
		{
			var json = JsonConvert.SerializeObject(obj, Formatting.Indented);
			Console.WriteLine(json);
		}
		
		private static int GetIntParameter()
		{
			var idInput = Console.ReadLine();
			var id = int.TryParse(idInput, out var parsedID)
				 ? parsedID
				 : 0;

			return id;
		}

		

		private void button2_Click(object sender, EventArgs e)
		{
			var scorer = database.ScorersList();
			WriteJson(scorer);
		}

		private void button3_Click(object sender, EventArgs e)
		{
			Console.WriteLine("Which scorer which you want remove");
			var idscorer = GetIntParameter();
			database.RemoveScorer(idscorer);
		}
		

		private void button4_Click(object sender, EventArgs e)
		{
			Console.WriteLine("Choose scorer which you want to see");
			var idscorer = GetIntParameter();
			Scorer scorer = database.GetScorerById(idscorer);

			var scorerViewModel = new
			{
				scorer.NameAndSurname,
				scorer.Nation,
				scorer.YearOfBirth,
				scorer.Goals,
				scorer.TotalGoals
			};
			WriteJson(scorerViewModel);
		}

		private void button5_Click(object sender, EventArgs e)
		{
			var scorers = database.SortScorersDescByTotalGoals();
			var query = scorers.Select(scorer => new { NameandSurname = scorer.NameAndSurname, YearOFBirth = scorer.YearOfBirth, Nation = scorer.Nation, TotalGoals = scorer.TotalGoals });
			WriteJson(query);
		}

		private void button6_Click(object sender, EventArgs e)
		{
			var scorers = database.SortScorersDescByChlGoals();
			var query = scorers.Select(scorer => new { NameandSurname = scorer.NameAndSurname, YearOFBirth = scorer.YearOfBirth, Nation = scorer.Nation, CHLGoals = scorer.Goals[CompetitionType.ChampionsLeague] });
			WriteJson(query);
		}

		private void button7_Click(object sender, EventArgs e)
		{
			var scorers = database.SortScorersDescByLeaquesGoals();
			var query = scorers.Select(scorer => new { NameandSurname = scorer.NameAndSurname, YearOFBirth = scorer.YearOfBirth, Nation = scorer.Nation, LeaqueGoals = scorer.Goals[CompetitionType.League] });
			WriteJson(query);
		}

		private void button8_Click(object sender, EventArgs e)
		{
			var scorers = database.SortScorersDescByNationalsGoals();
			var query = scorers.Select(scorer => new { NameandSurname = scorer.NameAndSurname, YearOFBirth = scorer.YearOfBirth, Nation = scorer.Nation, NationalGoals = scorer.Goals[CompetitionType.National] });
			WriteJson(query);
		}

		private void button9_Click(object sender, EventArgs e)
		{
			foreach (var scorer in database.ScorersList())
			{
				if (scorer.Goals[CompetitionType.League] > 500)
				{

					{
						Console.WriteLine("Name and Surname");
						Console.WriteLine(scorer.NameAndSurname);
						Console.WriteLine("Leaque Goals");
						Console.WriteLine(scorer.Goals[CompetitionType.League]);
						Console.WriteLine();
					}
				}
			}
		}

		private void button10_Click(object sender, EventArgs e)
		{
			foreach (var scorer in database.ScorersList())
			{
				if (scorer.Goals[CompetitionType.ChampionsLeague] > 50)
				{
					Console.WriteLine("Name and Surname");
					Console.WriteLine(scorer.NameAndSurname);
					Console.WriteLine("Champions Leaque Goals");
					Console.WriteLine(scorer.Goals[CompetitionType.ChampionsLeague]);
					Console.WriteLine();
				}
			}
		}

		private void button11_Click(object sender, EventArgs e)
		{
			foreach (var scorer in database.ScorersList())
			{
				if (scorer.Goals[CompetitionType.National] > 50)
				{
					Console.WriteLine("Name and Surname");
					Console.WriteLine(scorer.NameAndSurname);
					Console.WriteLine("National Goals");
					Console.WriteLine(scorer.Goals[CompetitionType.National]);
					Console.WriteLine();
				}
			}
		}

		private void button12_Click(object sender, EventArgs e)
		{
			Console.WriteLine("Choose id of scorer");
			var scorerid = GetIntParameter();

			var scorer = database.GetScorerById(scorerid);

			Console.WriteLine("Next Goals in Champions Leaque");
			var championsleaque = GetIntParameter();

			Console.WriteLine("Next goals in Leaques");
			var leaques = GetIntParameter();

			Console.WriteLine("Next goals in National Representation");
			var nationals = GetIntParameter();

			database.AddNextGoals(scorer, championsleaque, leaques, nationals);
		}

		private void Addscorer_Click(object sender, EventArgs e)
		{
			Console.WriteLine("Name and Surname");
			var nameAndSurname = Console.ReadLine();

			Console.WriteLine("YearofBirth");
			var yearOfBirth = GetIntParameter();

			Console.WriteLine("Nation");
			var nation = Console.ReadLine();

			Console.WriteLine("Goals in Champions Leaque");
			var championsleaque = GetIntParameter();


			Console.WriteLine("Goals in Leaques");
			var leaques = GetIntParameter();

			Console.WriteLine("Goals in National Representation");
			var nationals = GetIntParameter();

			var scorer = new Scorer
			{
				NameAndSurname = nameAndSurname,
				YearOfBirth = yearOfBirth,
				Nation = nation
			};

			scorer.Goals[CompetitionType.ChampionsLeague] = championsleaque;
			scorer.Goals[CompetitionType.League] = leaques;
			scorer.Goals[CompetitionType.National] = nationals;

			database.AddScorer(scorer);
		}
	}
}
