using AddressBook.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace AddressBook.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
            List<Contact> allContacts = Contact.GetAll();
            return View(allContacts);
        }

        [HttpGet("/contacts/new")]
        public ActionResult ContactForm()
        {
            return View();
        }

        [HttpPost("/contacts/new")]
        public ActionResult ContactFormResult()
        {
            Address newAddress = new Address(Request.Form["address-street"],Request.Form["address-city"],Request.Form["address-state"], Request.Form["address-zip"]);
            Contact newContact = new Contact(Request.Form["contact-name"], Request.Form["contact-phone"], newAddress);
            return View("ContactDetail", newContact);
        }

        [HttpGet("/contacts/{id}")]
        public ActionResult ContactDetail(int id)
        {
            Contact selectedContact = Contact.Find(id);
            selectedContact.ChangeNewStatus();
            return View(selectedContact);
        }

        [HttpPost("/contacts/{id}/remove")]
        public ActionResult ContactClear(int id)
        {
            Contact selectedContact = Contact.Find(id);
            Contact.RemoveContact(id);
            return View(selectedContact);
        }

        [HttpPost("/contacts/search")]
        public ActionResult ContactSearchResults()
        {
            Dictionary<string, object> model = new Dictionary<string, object>();
            string searchInput = Request.Form["name-search"];
            List<Contact> allContacts = Contact.GetAll();
            List<Contact> matchedContacts = Contact.SearchContacts(allContacts, Request.Form["name-search"]);
            model.Add("input", searchInput);
            model.Add("inputMatches", matchedContacts);
            // List<Contact> matchedContacts = Contact.SearchContacts(allContacts, Request.Form["name-search"]);
            return View(model);
        }

        [HttpPost("/contacts/clear")]
        public ActionResult ContactListClear()
        {
            Contact.ClearAll();
            return View();
        }

    }
}
