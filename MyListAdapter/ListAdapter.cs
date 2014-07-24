using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace MyListAdapter
{
	/// <summary>
	/// List adapter.
	/// ListView数据适配器
	/// </summary>
	public class ListAdapter : BaseAdapter<Application>
	{
		private Activity context = null;
		public List<Application> list = null;

        /// <summary>
        /// 默认构造器
        /// </summary>
		public ListAdapter ()
		{
		}

        /// <summary>
        /// 带参构造器
        /// </summary>
        /// <param name="context"></param>
        /// <param name="list"></param>
		public ListAdapter (Activity context, List<Application> list): base()
		{
			this.context = context;
			this.list = list;
		}

		public override int Count {
            get { return this.list.Count; }
		}

		public override Application this [int position] {
            get { return this.list[position]; }
		}

		public override View GetView (int position, View convertView, ViewGroup parent)
		{
            var item = this.list[position];
			var view = convertView;

            if (convertView == null || !(convertView is LinearLayout))
            {
                view = context.LayoutInflater.Inflate(Resource.Layout.Main, parent, false);
            }

			var imageItem = view.FindViewById (Resource.Id.imageView_item) as ImageView;
			var tvName = view.FindViewById (Resource.Id.textview_top) as TextView;
			var tvDescrtion = view.FindViewById (Resource.Id.textview_bottom) as TextView;

			imageItem.SetImageResource (item.Image);
			tvName.SetText (item.Name, TextView.BufferType.Normal);
			tvDescrtion.SetText (item.Description, TextView.BufferType.Normal);

			view.Click += delegate(object sender, EventArgs e)
			{
				Toast.MakeText(context,((TextView)tvName).Text,ToastLength.Long).Show();
			};

			return view;
		}

		public override long GetItemId (int position)
		{
			return position;
		}
	}
}