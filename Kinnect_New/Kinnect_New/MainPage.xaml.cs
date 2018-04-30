using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Kinnect_New
{
    public class Color
    {
        public string Box1Color { get; set; }
        public string Box2Color { get; set; }
    }

    public class Mentor
    {
        public string UserId { get; set; }

        public string Gender { get; set; }
        public int Age { get; set; }

        public long TotalScore { get; set; }

        public string Name { get; set; }
        public string PositionTitle { get; set; }

        public string Location { get; set; }

        public string Industry { get; set; }
        public string OrganisationType { get; set; }

        public string FocusArea { get; set; }

        public string OrganisationName { get; set; }
        public string OverseasExperience { get; set; }

        public string ProfessionalInterests { get; set; }

    }

    public static class Mentors
    {
        public static List<Mentor> Results { get; set; } = new List<Mentor>();

    }

    public partial class MainPage : ContentPage
    {
        public MainPage()

        {
            InitializeComponent();

            var colors = new List<Color>
            {
                new Color {Box1Color="Green", Box2Color="Orange"},
                new Color {Box1Color="Yellow", Box2Color="Aqua"},
                new Color {Box1Color="Blue", Box2Color="Silver"},
                new Color {Box1Color="Purple", Box2Color="Teal"},
            };

            var mentors = new List<Mentor>
            {
                new Mentor
                {
                    UserId = "1",
                    TotalScore = 90,
                    Name = "Kevin",
                    PositionTitle = "Pricing Manager",
                    Location = "Sydney, Australia",
                    Industry = "Life Insurance",
                    OrganisationType = "Corporate",
                    FocusArea = "Pricing",
                    OrganisationName = "TAL",
                    OverseasExperience = "Australia, Hong Kong",
                    ProfessionalInterests = "Prophet, Data Science"
                },

                new Mentor
                {
                    UserId = "1",
                    TotalScore = 80,
                    Name = "Joe",
                    PositionTitle = "GM of Pricing",
                    Location = "Sydney, Australia",
                    Industry = "Life Insurance",
                    OrganisationType = "Corporate",
                    FocusArea = "Pricing",
                    OrganisationName = "TAL",
                    OverseasExperience = "Australia",
                    ProfessionalInterests = "Prophet, Data Science"
                }

            };

            MainCarouselView.ItemsSource = mentors;

        }
    }
}
