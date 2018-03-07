using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Support.V4.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Provider;

namespace HelloSwipeViewWithTabs
{
    public class ContactsAdapter : BaseAdapter
    {
        List<Contact> _contactList;
        Android.Support.V4.App.Fragment _activity;

        public ContactsAdapter(Android.Support.V4.App.Fragment activity)
        {
            _activity = activity;

            FillContacts();
        }

        public override int Count
        {
            get { return _contactList.Count; }
        }

        public override Java.Lang.Object GetItem(int position)
        {
            return null; // could wrap a Contact in a Java.Lang.Object to return it here if needed
        }

        public override long GetItemId(int position)
        {
            return _contactList[position].Id;
        }


        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var view = convertView ?? _activity.LayoutInflater.Inflate(Resource.Layout.ContactListItem, parent, false);
            var contactName = view.FindViewById<TextView>(Resource.Id.ContactName);
            var contactImage = view.FindViewById<ImageView>(Resource.Id.ContactImage);

            contactName.Text = _contactList[position].DisplayName;

            if (_contactList[position].PhotoId == null)
            {

                contactImage = view.FindViewById<ImageView>(Resource.Id.ContactImage);
                contactImage.SetImageResource(Resource.Drawable.ContactImage);

            }
            else
            {

                var contactUri = ContentUris.WithAppendedId(ContactsContract.Contacts.ContentUri, _contactList[position].Id);
                var contactPhotoUri = Android.Net.Uri.WithAppendedPath(contactUri, Contacts.Photos.ContentDirectory);

                contactImage.SetImageURI(contactPhotoUri);
            }
            return view;
        }
        

        void FillContacts()
        {
            var uri = ContactsContract.Contacts.ContentUri;

            string[] projection = {
                ContactsContract.Contacts.InterfaceConsts.Id,
                ContactsContract.Contacts.InterfaceConsts.DisplayName,
                ContactsContract.Contacts.InterfaceConsts.PhotoId
            };

           

            _contactList = new List<Contact>();

                    _contactList.Add(new Contact
                    {
                        Id = 1,
                        DisplayName ="Raja",
                        PhotoId = "Windows"
                    });
            _contactList.Add(new Contact
            {
                Id = 1,
                DisplayName = "Raja",
                PhotoId = "Windows"
            });

            _contactList.Add(new Contact
            {
                Id = 1,
                DisplayName = "Raja",
                PhotoId = "Windows"
            });

            _contactList.Add(new Contact
            {
                Id = 1,
                DisplayName = "Raja",
                PhotoId = "Windows"
            });

            _contactList.Add(new Contact
            {
                Id = 1,
                DisplayName = "Raja",
                PhotoId = "Windows"
            });

            _contactList.Add(new Contact
            {
                Id = 1,
                DisplayName = "Raja",
                PhotoId = "Windows"
            });

            _contactList.Add(new Contact
            {
                Id = 1,
                DisplayName = "Raja",
                PhotoId = "Windows"
            });

            _contactList.Add(new Contact
            {
                Id = 1,
                DisplayName = "Raja",
                PhotoId = "Windows"
            });

            _contactList.Add(new Contact
            {
                Id = 1,
                DisplayName = "Raja",
                PhotoId = "Windows"
            });

            _contactList.Add(new Contact
            {
                Id = 1,
                DisplayName = "Raja",
                PhotoId = "Windows"

            });

            _contactList.Add(new Contact
            {
                Id = 1,
                DisplayName = "Raja",
                PhotoId = "Windows"
            });

        } 
            }
        

        class Contact
        {
            public long Id { get; set; }

            public string DisplayName { get; set; }

            public string PhotoId { get; set; }
        }
    

}