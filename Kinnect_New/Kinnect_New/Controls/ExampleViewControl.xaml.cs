using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Kinnect_New.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ExampleViewControl : ContentView
    {
        #region  FullName
        public static readonly BindableProperty FullNameProperty = BindableProperty.Create(
                                                                                    propertyName: "FullName",
                                                                                    returnType: typeof(string),
                                                                                    declaringType: typeof(ExampleViewControl),
                                                                                    defaultBindingMode: BindingMode.TwoWay,
                                                                                    propertyChanged: FullNamePropertyChanged);

        public string FullName
        {
            get { return GetValue(FullNameProperty).ToString(); }
            set { SetValue(FullNameProperty, value); }
        }

        private static void FullNamePropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (ExampleViewControl)bindable;
            control.FullNameValue.Text = newValue.ToString();
        }
        #endregion

        #region JobTitle
        public static readonly BindableProperty JobTitleProperty = BindableProperty.Create(
                                                                                    propertyName: "JobTitle",
                                                                                    returnType: typeof(string),
                                                                                    declaringType: typeof(ExampleViewControl),
                                                                                    defaultBindingMode: BindingMode.TwoWay,
                                                                                    propertyChanged: JobTitlePropertyChanged);

        public string JobTitle
        {
            get { return GetValue(JobTitleProperty).ToString(); }
            set { SetValue(JobTitleProperty, value); }
        }

        private static void JobTitlePropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (ExampleViewControl)bindable;
            control.JobTitleValue.Text = newValue.ToString();
        }
        #endregion

        #region Score
        public static readonly BindableProperty ScoreProperty = BindableProperty.Create(
                                                                                    propertyName: "Score",
                                                                                    returnType: typeof(string),
                                                                                    declaringType: typeof(ExampleViewControl),
                                                                                    defaultBindingMode: BindingMode.TwoWay,
                                                                                    propertyChanged: ScorePropertyChanged);

        public string Score
        {
            get { return GetValue(ScoreProperty).ToString(); }
            set { SetValue(ScoreProperty, value); }
        }

        private static void ScorePropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (ExampleViewControl)bindable;
            control.ScoreValue.Text = String.Format("{0}%", newValue.ToString());
        }
        #endregion

        #region Location
        public static readonly BindableProperty LocationProperty = BindableProperty.Create(
                                                                                    propertyName: "Location",
                                                                                    returnType: typeof(string),
                                                                                    declaringType: typeof(ExampleViewControl),
                                                                                    defaultBindingMode: BindingMode.TwoWay,
                                                                                    propertyChanged: LocationPropertyChanged);

        public string Location
        {
            get { return GetValue(LocationProperty).ToString(); }
            set { SetValue(LocationProperty, value); }
        }

        private static void LocationPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (ExampleViewControl)bindable;
            control.LocationValue.Text = newValue.ToString();
        }
        #endregion

        #region Industry
        public static readonly BindableProperty IndustryProperty = BindableProperty.Create(
                                                                                    propertyName: "Industry",
                                                                                    returnType: typeof(string),
                                                                                    declaringType: typeof(ExampleViewControl),
                                                                                    defaultBindingMode: BindingMode.TwoWay,
                                                                                    propertyChanged: IndustryPropertyChanged);

        public string Industry
        {
            get { return GetValue(IndustryProperty).ToString(); }
            set { SetValue(IndustryProperty, value); }
        }

        private static void IndustryPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (ExampleViewControl)bindable;
            control.IndustryValue.Text = newValue.ToString();
        }
        #endregion

        #region FocusArea
        public static readonly BindableProperty FocusAreaProperty = BindableProperty.Create(
                                                                                    propertyName: "FocusArea",
                                                                                    returnType: typeof(string),
                                                                                    declaringType: typeof(ExampleViewControl),
                                                                                    defaultBindingMode: BindingMode.TwoWay,
                                                                                    propertyChanged: FocusAreaPropertyChanged);

        public string FocusArea
        {
            get { return GetValue(FocusAreaProperty).ToString(); }
            set { SetValue(FocusAreaProperty, value); }
        }

        private static void FocusAreaPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (ExampleViewControl)bindable;
            control.FocusAreaValue.Text = newValue.ToString();
        }
        #endregion

        #region Organisation
        public static readonly BindableProperty OrganisationProperty = BindableProperty.Create(
                                                                                    propertyName: "Organisation",
                                                                                    returnType: typeof(string),
                                                                                    declaringType: typeof(ExampleViewControl),
                                                                                    defaultBindingMode: BindingMode.TwoWay,
                                                                                    propertyChanged: OrganisationPropertyChanged);

        public string Organisation
        {
            get { return GetValue(OrganisationProperty).ToString(); }
            set { SetValue(OrganisationProperty, value); }
        }

        private static void OrganisationPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (ExampleViewControl)bindable;
            control.OrganisationValue.Text = newValue.ToString();
        }

        #endregion

        #region CurrentEmployer
        public static readonly BindableProperty CurrentEmployerProperty = BindableProperty.Create(
                                                                                    propertyName: "CurrentEmployer",
                                                                                    returnType: typeof(string),
                                                                                    declaringType: typeof(ExampleViewControl),
                                                                                    defaultBindingMode: BindingMode.TwoWay,
                                                                                    propertyChanged: CurrentEmployerPropertyChanged);

        public string CurrentEmployer
        {
            get { return GetValue(CurrentEmployerProperty).ToString(); }
            set { SetValue(CurrentEmployerProperty, value); }
        }

        private static void CurrentEmployerPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (ExampleViewControl)bindable;
            control.CurrentEmployerValue.Text = newValue.ToString();
        }
        #endregion

        #region OverseasExperience
        public static readonly BindableProperty OverseasExperienceProperty = BindableProperty.Create(
                                                                                    propertyName: "OverseasExperience",
                                                                                    returnType: typeof(string),
                                                                                    declaringType: typeof(ExampleViewControl),
                                                                                    defaultBindingMode: BindingMode.TwoWay,
                                                                                    propertyChanged: OverseasExperiencePropertyChanged);
        public string OverseasExperience
        {
            get { return GetValue(OverseasExperienceProperty).ToString(); }
            set { SetValue(OverseasExperienceProperty, value); }
        }

        private static void OverseasExperiencePropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (ExampleViewControl)bindable;
            control.OverseasExperienceValue.Text = newValue.ToString();
        }
        #endregion

        #region ProfessionalInterests
        public static readonly BindableProperty ProfessionalInterestsProperty = BindableProperty.Create(
                                                                                    propertyName: "ProfessionalInterests",
                                                                                    returnType: typeof(string),
                                                                                    declaringType: typeof(ExampleViewControl),
                                                                                    defaultBindingMode: BindingMode.TwoWay,
                                                                                    propertyChanged: ProfessionalInterestsPropertyChanged);

        public string ProfessionalInterests
        {
            get { return GetValue(ProfessionalInterestsProperty).ToString(); }
            set { SetValue(ProfessionalInterestsProperty, value); }
        }

        private static void ProfessionalInterestsPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (ExampleViewControl)bindable;
            control.ProfessionalInterestsValue.Text = newValue.ToString();
        }
        #endregion

        //private double ScalingFactor;

        public ExampleViewControl()
        {
            InitializeComponent();
            //ScalingFactor = (float)256 / 375;
            ////App.Current.MainPage.DisplayAlert("Error", String.Format("{0:F2}", ScalingFactor), "Ok");
            //OneGrid.ColumnDefinitions[0].Width = new GridLength(125 * ScalingFactor, GridUnitType.Absolute);
            //OneGrid.ColumnDefinitions[1].Width = new GridLength(210 * ScalingFactor, GridUnitType.Absolute);

            //OneGrid.RowDefinitions[0].Height = new GridLength(335 * ScalingFactor, GridUnitType.Absolute);
            //OneGrid.RowDefinitions[1].Height = new GridLength(70 * ScalingFactor, GridUnitType.Absolute);
        }
    }
}
