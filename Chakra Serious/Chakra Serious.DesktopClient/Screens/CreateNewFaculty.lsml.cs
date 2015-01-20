using System;
using System.Linq;
using System.IO;
using System.IO.IsolatedStorage;
using System.Collections.Generic;
using Microsoft.LightSwitch;
using Microsoft.LightSwitch.Framework.Client;
using Microsoft.LightSwitch.Presentation;
using Microsoft.LightSwitch.Presentation.Extensions;

namespace LightSwitchApplication
{
    public partial class CreateNewFaculty
    {
        partial void CreateNewFaculty_InitializeDataWorkspace(List<IDataService> saveChangesTo)
        {
            // Write your code here.
            this.BiodataProperty = new Biodata();
        }

        partial void CreateNewFaculty_Saved()
        {
            // Write your code here.
            this.Close(false);
            Application.Current.ShowDefaultScreen(this.BiodataProperty);
        }
    }
}