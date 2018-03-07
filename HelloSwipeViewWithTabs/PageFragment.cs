using System;
using Android.OS;
using Android.Support.V4.App;
using Android.Views;
using Android.Widget;
using Java.Lang;
using Android.Content;

namespace HelloSwipeViewWithTabs
{
    public class PageFragment : Fragment
    {
        const string ARG_PAGE = "ARG_PAGE";
        private int mPage;
        ContactsAdapter contactsAdapter;
        public static PageFragment newInstance(int page)
        {
            var args = new Bundle();
            args.PutInt(ARG_PAGE, page);
            var fragment = new PageFragment();
            fragment.Arguments = args;
            return fragment;
        }

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            mPage = Arguments.GetInt(ARG_PAGE);
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            if (mPage==1)
            {
                var view = inflater.Inflate(Resource.Layout.layout1, container, false);
                Button b=  view.FindViewById<Button>(Resource.Id.button1);
                b.Click += B_Click;
                return view;
            }
            else
            {
                var view = inflater.Inflate(Resource.Layout.fragment_page, container, false);
                contactsAdapter = new ContactsAdapter(this);
                
                var contactsListView = view.FindViewById<ListView>(Resource.Id.ContactsListView);
                contactsListView.Adapter = contactsAdapter;
                return view;
            }
          
        }

        private void B_Click(object sender, EventArgs e)
        {
            Intent i = new Intent(this.Activity.ApplicationContext,typeof(Activity1));
            StartActivity(i);
        }
    }
}