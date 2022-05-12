using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsReview.Data
{
    public class Employment
    {
        //An instance of this class may hold data about a person's employment
        // char of class
        /*
         * Data fields
        are storage area in the class
        treated as variables
        these may be public, private, public readonly

        Property
        Access techniques to retrieve or set data in your class without directly touching the storage data field
        A property is associated with a single instance of data
        A property is public so it can be access by an outsider user of the class
        A property must have a get
        A property may have a set
        If no set, the property is not changable by the user, it is bascially read only Commonly used for calculated data of the class
        The set can be eithier public or private 
        public: the user can alter the contents of the data
        Private: only code within the class can alter the contents
         */
        public string Titile
        {
            get;
            set;
        }
    }
}
