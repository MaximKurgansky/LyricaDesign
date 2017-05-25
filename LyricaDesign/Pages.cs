using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LyricaDesign
{
    static class Pages
    {
        private static SignInPage _signinpage = new SignInPage();
        private static CreateAccountPage _createaccountpage = new CreateAccountPage();
        private static SearchPage _searchpage = new SearchPage();
        private static LoadPage _loadpage = new LoadPage();


        public static SignInPage SignInPage
        {
            get
            {
                return _signinpage;
            }
        }

        public static CreateAccountPage CreateAccountPage
        {
            get
            {
                return _createaccountpage;
            }
        }

        public static SearchPage SearchPage
        {
            get
            {
                return _searchpage;
            }
        }

        public static LoadPage LoadPage
        {
            get
            {
                return _loadpage;
            }
        }
    }
}
