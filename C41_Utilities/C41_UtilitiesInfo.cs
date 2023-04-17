using Grasshopper.Kernel;
using System;
using System.Drawing;

namespace C41_Utilities
{
    public class C41_UtilitiesInfo : GH_AssemblyInfo
    {
        public override string Name
        {
            get
            {
                return "C41Utilities";
            }
        }
        public override Bitmap Icon
        {
            get
            {
                //Return a 24x24 pixel bitmap to represent this GHA library.
                return null;
            }
        }
        public override string Description
        {
            get
            {
                //Return a short string describing the purpose of this GHA library.
                return "";
            }
        }
        public override Guid Id
        {
            get
            {
                return new Guid("25c96c16-445c-4f09-9351-16e46c5c79d1");
            }
        }

        public override string AuthorName
        {
            get
            {
                //Return a string identifying you or your company.
                return "RB";
            }
        }
        public override string AuthorContact
        {
            get
            {
                //Return a string representing your preferred contact details.
                return "";
            }
        }
    }
}
