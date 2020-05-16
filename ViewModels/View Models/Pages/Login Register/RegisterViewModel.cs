﻿using Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ViewModels
{
    public class RegisterViewModel : ViewModelBase
    {
        #region Private Fields

        private int _yearsRange = 120;
        private List<string> _months;
        private List<int> _years;

        #endregion

        #region Public Properties

        /// <summary>
        /// The user currently registering
        /// </summary>
        public User RegisteringUser { get; set; }

        /// <summary>
        /// The email of the user
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// The password of the user
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// The range of the maximum days a month can have
        /// </summary>
        public List<int> Days { get => Enumerable.Range(1, 31).ToList(); }

        /// <summary>
        /// The range of the maximum months a year can have
        /// </summary>
        public List<string> Months { get => _months; }

        /// <summary>
        /// The years range a user can be born between
        /// </summary>
        public List<int> Years { get => _years; }

        #endregion

        #region Commands

        /// <summary>
        /// The command to change the page to the register date page
        /// </summary>
        public ICommand MoveToRegisterDatePageCommand { get; set; }

        /// <summary>
        /// The command to change the page to the register password page
        /// </summary>
        public ICommand MoveToRegisterPasswordPageCommand { get; set; }

        /// <summary>
        /// The command to change the page to the main page
        /// </summary>
        public ICommand LeaveCommand { get; set; }

        #endregion

        #region Constructor

        public RegisterViewModel()
        {
            _years = Enumerable.Range(GetCurrentYear() - _yearsRange, _yearsRange + 1).ToList();
            _years.Reverse();

            _months = DateTimeFormatInfo.CurrentInfo.MonthNames.ToList();
            _months.RemoveAll(x => string.IsNullOrEmpty(x));

            MoveToRegisterDatePageCommand = new RelayCommand(async () => await MoveToRegisterDatePage());
            MoveToRegisterPasswordPageCommand = new RelayCommand(async () => await MoveToRegisterPasswordPage());
            LeaveCommand = new RelayCommand(() => Leave());
        }

        #endregion

        #region Helper Methods

        /// <summary>
        /// Gets the current year
        /// </summary>
        /// <returns></returns>
        private int GetCurrentYear()
        {
            //TODO: Get the actual year from the internet?
            return DateTime.Now.Year;
        }

        /// <summary>
        /// Returns true if email address is valid.
        /// </summary>
        /// <param name="email">Email</param>
        /// <returns></returns>
        private bool IsEmailAddressFormatValid(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                // Normalize the domain
                email = Regex.Replace(email, @"(@)(.+)$", DomainMapper,
                                      RegexOptions.None, TimeSpan.FromMilliseconds(200));

                // Examines the domain part of the email and normalizes it.
                string DomainMapper(Match match)
                {
                    // Use IdnMapping class to convert Unicode domain names.
                    var idn = new IdnMapping();

                    // Pull out and process domain name (throws ArgumentException on invalid)
                    var domainName = idn.GetAscii(match.Groups[2].Value);

                    return match.Groups[1].Value + domainName;
                }
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
            catch (ArgumentException)
            {
                return false;
            }

            try
            {
                return Regex.IsMatch(email,
                    @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                    @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }

        #endregion

        /// <summary>
        /// Takes the user to the register date page
        /// </summary>
        /// <returns></returns>
        public async Task MoveToRegisterDatePage()
        {
            if (IsEmailAddressFormatValid(Email))
            {
                // Go to register date page
                IoC.Get<ApplicationViewModel>().CurrentPage = ApplicationPage.RegisterDate;
            }
            else
            {
                // TODO: Complete this function's logic
            }



            await Task.Delay(1);
        }

        /// <summary>
        /// Takes the user to the register password page
        /// </summary>
        /// <returns></returns>
        public async Task MoveToRegisterPasswordPage()
        {
            // TODO: Complete this function's logic

            // Go to register date page
            IoC.Get<ApplicationViewModel>().CurrentPage = ApplicationPage.RegisterPassword;

            await Task.Delay(1);
        }

        private void Leave()
        {
            IoC.Application.GoToPage(ApplicationPage.Login);
        }
    }
}