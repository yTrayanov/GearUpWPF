using System;
using System.Collections.Generic;
using System.Text;

namespace ClientSide.ViewBindingModels
{
    public class CurrentUserBindingModel
    {

        public string Token { get; set; }

        public UserInfo User { get; set; }
    }

}
