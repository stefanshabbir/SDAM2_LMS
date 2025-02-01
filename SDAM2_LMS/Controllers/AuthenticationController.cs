﻿using SDAM2_LMS.ErrorLog;
using SDAM2_LMS.Models;
using SDAM2_LMS.Models.Data;
using SDAM2_LMS.Models.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SDAM2_LMS.Controllers
{
    public class AuthenticationController
    {
        private readonly AccountService _accountService;
        private readonly BookController _bookController;
        private readonly BorrowController _borrowController;

        private const int ADMIN = 1;
        private const int LIBRARIAN = 2;

        public AuthenticationController(
            AccountService accountService, BorrowController borrowController, BookController bookController
            )
        {
            _accountService = accountService;
            _bookController = bookController;
            _borrowController = borrowController;
        }

        public bool Login(string username, string password)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(username))
                {
                    MessageBox.Show("Username cannot be empty!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                if (string.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show("Password cannot be empty!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                var user = _accountService.Login(username, password);

                bool loginSuccessful = user != null;
                if (loginSuccessful)
                {
                    if (user.AccountTypeID == ADMIN)
                    {
                        var dashboard = new AdminDashboard();
                        dashboard.Show();
                        return true;
                    }
                    else if (user.AccountTypeID == LIBRARIAN)
                    {
                        var dashboard = new LibrarianDashboard(
                            new ProfileController(_accountService)
                            );
                        dashboard.Show();
                        return true;
                    }
                    else
                    {
                        var dashboard = new MemberDashboard(
                            new ProfileController(_accountService), _borrowController, _bookController
                            );
                        dashboard.Show();
                        return true;
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception ex)
            {
                new WriteErrorLog(ex);
                MessageBox.Show($"An Unexpected Error occured. Check logs for more details. \nError: \n {ex}");
                return false;
            }
            
        }

        // NEEDS ERROR HANDLING; A lot of rework, most stuff from the Register winform need to be brought here
        // Success and error messages and all error handling should be here
        public bool Register(string username, string password, string email,string name, string address, string phone)
        {
            bool accountRegistered = _accountService.Register(username, password, email, name, address, phone);
            if (accountRegistered)
            {
                MessageBox.Show("Registration Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                var dashboard = new MemberDashboard(
                    new ProfileController(_accountService), _borrowController, _bookController
                    );
                dashboard.Show();
                return true;
            }
            else
            {
                MessageBox.Show("Account already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

    }
}
