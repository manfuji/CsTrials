using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.ConditionalAppearance;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo;
using DevExpress.XtraRichEdit.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace trials.Module.BusinessObjects
{
    [DefaultClassOptions]
    [ImageName("BO_Contact")]
    [Appearance("ActiveStudent", Criteria = "IsActive=true", TargetItems = "*", FontColor = "green",FontStyle =System.Drawing.FontStyle.Bold)]
    //[DefaultProperty("DisplayMemberNameForLookupEditorsOfThisType")]
    //[DefaultListViewOptions(MasterDetailMode.ListViewOnly, false, NewItemRowPosition.None)]
    //[Persistent("DatabaseTableName")]
    // Specify more UI options using a declarative approach (https://documentation.devexpress.com/#eXpressAppFramework/CustomDocument112701).
    public class Student : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public Student(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
            IsActive = true;
        }

        private string _FirstName;

        public string FirstName
        {
            get { return _FirstName; }
            set { SetPropertyValue<string>(nameof(FirstName), ref _FirstName, value); }
        }

        private string _LastName;

        public string LastName
        {
            get { return _LastName; }
            set { SetPropertyValue<string>(nameof(LastName), ref _LastName, value); }
        }

        private string _Email;

        public string Email
        {
            get { return _Email; }
            set { SetPropertyValue<string>(nameof(Email), ref _Email, value); }
        }

        private bool _IsActive;

        public bool IsActive
        {
            get { return _IsActive; }
            set { SetPropertyValue<bool>(nameof(IsActive), ref _IsActive, value); }
        }



        private School _School;
        [Association]
            public School School
        {
            get { return _School; }
            set { SetPropertyValue<School>(nameof(School), ref _School, value); }
        }
    }
}