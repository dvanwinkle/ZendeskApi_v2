﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using RestSharp;
using RestSharp.Contrib;
using ZenDeskApi_v2.Requests;

namespace ZenDeskApi_v2
{
    public class ZendeskApi
    {
        public Tickets Tickets { get; set; }
        public Attachments Attachments { get; set; }
        public Views Views { get; set; }
        public Users Users { get; set; }
        public Requests.Requests Requests { get; set; }
        public Groups Groups { get; set; }
        public CustomAgentRoles CustomAgentRoles { get; set; }
        public Organizations Organizations { get; set; }
        public Search Search { get; set; }
        public Tags Tags { get; set; }

        public ZendeskApi(string yourZenDeskUrl, string user, string password)
        {
            Tickets = new Tickets(yourZenDeskUrl, user, password);
            Attachments = new Attachments(yourZenDeskUrl, user, password);
            Views = new Views(yourZenDeskUrl, user, password);
            Users = new Users(yourZenDeskUrl, user, password);
            Requests = new Requests.Requests(yourZenDeskUrl, user, password);
            Groups = new Groups(yourZenDeskUrl, user, password);
            CustomAgentRoles = new CustomAgentRoles(yourZenDeskUrl, user, password);
            Organizations = new Organizations(yourZenDeskUrl, user, password);
            Search = new Search(yourZenDeskUrl, user, password);
            Tags = new Tags(yourZenDeskUrl, user, password);
        }
    }
}
