using ClientSide.RequestServices;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace ClientSide.Views.Auth
{
    public abstract class AuthControl : UserControl
    {
        public AuthControl()
        {
            this.AuthService = new AuthService();
        }

        protected AuthService AuthService { get;private set; }
    }
}
