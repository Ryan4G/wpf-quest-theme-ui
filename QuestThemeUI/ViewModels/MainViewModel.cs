using QuestThemeUI.Commands;
using QuestThemeUI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;

namespace QuestThemeUI.ViewModels
{
    public class MainViewModel : BindableBase
    {
        private PageModel _pageModel;

        private List<string> _framePages;

        private ThemeModel _themeModel;
        private List<ThemeModel> _themeModels;

        public MainViewModel()
        {
            _pageModel = new PageModel();

            NextCommand = new JumpCommand(() =>
            {
                if (PageModel.NextBtnContent == "FINISH")
                {
                    Task.Run(() =>
                    {
                        Task.Delay(2000);
                        MessageBox.Show("Thanks for your submit!", "Notice", MessageBoxButton.OK, MessageBoxImage.Information);
                    });
                }
                else
                {
                    if (PageModel.CurrentPageIndex == 0 && !ValidateUserModel())
                    {
                        return;
                    }

                    if (PageModel.CurrentPageIndex + 1 >= _framePages.Count - 1)
                    {
                        PageModel.NextBtnContent = "FINISH";
                    }

                    PageModel.ShowPrevious = true;
                    PageModel.CurrentPagePath = _framePages[++PageModel.CurrentPageIndex];
                }

            });

            PreviousCommand = new JumpCommand(() =>
            {
                if (PageModel.CurrentPageIndex - 1 <= 0)
                {
                    PageModel.ShowPrevious = false;
                }

                PageModel.NextBtnContent = "NEXT";
                PageModel.ShowNext = true;
                PageModel.CurrentPagePath = _framePages[--PageModel.CurrentPageIndex];
            });

            _framePages = new List<string>();
            _framePages.Add("Pages/AboutPage.xaml");
            _framePages.Add("Pages/AccountPage.xaml");
            _framePages.Add("Pages/AddressPage.xaml");

            PageModel.NextBtnContent = "NEXT";
            PageModel.CurrentPagePath = _framePages[PageModel.CurrentPageIndex];

            _themeModels = new List<ThemeModel>();

            _themeModels.Add(new ThemeModel { ThemePicture = "Images/bg1.jpg", ThemeTitle = "Theme One" });
            _themeModels.Add(new ThemeModel { ThemePicture = "Images/bg2.jpg", ThemeTitle = "Theme Two" });

            _themeModel = _themeModels.First();
        }

        public PageModel PageModel
        {
            get
            {
                return _pageModel;
            }

            set
            {
                SetProperty(ref _pageModel, value);
            }
        }

        public ThemeModel ThemeModel
        {
            get
            {
                return _themeModel;
            }

            set
            {
                SetProperty(ref _themeModel, value);
            }
        }

        public List<ThemeModel> ThemeModels
        {
            get
            {
                return _themeModels;
            }

            set
            {
                SetProperty(ref _themeModels, value);
            }
        }

        public JumpCommand NextCommand { get; set; }
        public JumpCommand PreviousCommand { get; set; }

        public bool ValidateUserModel()
        {
            var result = false;

            var stdUserModel = DataStorage.GetUserModelInstance();

            var validateResults = new List<ValidationResult>();

            result = Validator.TryValidateObject(stdUserModel, new ValidationContext(stdUserModel), validateResults, true);

            return result;
        }
    }
}
