using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace trials.Module.BusinessObjects
{
    [DefaultClassOptions]
    [ImageName("BO_Department")]
  
    public class School : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public School(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }
   

        private string _SchoolName;
        [RuleRequiredField]
        [RuleUniqueValue]
        public string SchoolName
        {
            get { return _SchoolName; }
            set { SetPropertyValue<string>(nameof(SchoolName),ref _SchoolName, value); }
        }

        private string _Website;
        [RuleRequiredField]
        [RuleUniqueValue]
        public string Website
        {
            get { return _Website; }
            set { SetPropertyValue<string>(nameof(Website), ref _Website, value); }
        }


        private string _LocationAddress;
        [RuleRequiredField]
        public string LocationAddress
        {
            get { return _LocationAddress; }
            set { SetPropertyValue<string>(nameof(LocationAddress), ref _LocationAddress, value); }
        }


        [DevExpress.Xpo.Aggregated,Association]
        public XPCollection<Student> Students
        {
            get { return GetCollection<Student>(nameof(Students)); }
        }
    }
}