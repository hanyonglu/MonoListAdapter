using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;

namespace MyListAdapter
{
	[Activity (Label = "MyListAdapter", MainLauncher = true)]
	public class MainActivity : ListActivity
	{
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // ???????
            InitListData();
        }

        /// <summary>
        /// ???????
        /// </summary>
        public void InitListData()
        {
            this.ListAdapter = new ListAdapter(this,
            new List<Application>() {
				new Application() { Name = "angrybirds",Description = "angrybirds",Image = Resource.Drawable.angrybirds },
				new Application() { Name = "camera",Description = "camera",Image = Resource.Drawable.camera },
				new Application() { Name = "evernotealt",Description = "evernotealt",Image = Resource.Drawable.evernotealt },
				new Application() { Name = "fruitninja Mouse",Description = "fruitninja",Image = Resource.Drawable.fruitninja },
				new Application() { Name = "gtalk",Description = "gtalk",Image = Resource.Drawable.gtalk },
				new Application() { Name = "handcent",Description = "handcent",Image = Resource.Drawable.handcent },
				new Application() { Name = "maps",Description = "maps",Image = Resource.Drawable.maps },
				new Application() { Name = "tasks",Description = "tasks",Image = Resource.Drawable.tasks },
				new Application() { Name = "twitterblue",Description = "twitterblue",Image = Resource.Drawable.twitterblue },
				new Application() { Name = "widgetlocker",Description = "widgetlocker",Image = Resource.Drawable.widgetlocker },
				new Application() { Name = "youtube",Description = "youtube",Image = Resource.Drawable.youtube }, 
				new Application() { Name = "settingsa",Description = "settingsa",Image = Resource.Drawable.settingsa },
				new Application() { Name = "cam360",Description = "cam360",Image = Resource.Drawable.cam360 },
				new Application() { Name = "downloads",Description = "downloads",Image = Resource.Drawable.downloads },
				new Application() { Name = "dropbox",Description = "dropbox",Image = Resource.Drawable.dropbox },
				new Application() { Name = "evernote",Description = "evernote",Image = Resource.Drawable.evernote },
				new Application() { Name = "recorder",Description = "recorder",Image = Resource.Drawable.recorder }
			}
            );
        }
	}
}