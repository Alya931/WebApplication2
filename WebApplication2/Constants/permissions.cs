using System;
using System.Collections.Generic;

namespace WebApplication2.Constants
{
    public static class Permissions
    {
        public static List<string> GeneratePermissionsForModule(string module)
        {
            return new List<string>()
        {
            $"Permissions.{module}.Create",
            $"Permissions.{module}.View",
            $"Permissions.{module}.Edit",
            $"Permissions.{module}.Delete",
        };
        }

        public static class Products
        {
            public const string View = "Permissions.Products.View";
            public const string Create = "Permissions.Products.Create";
            public const string Edit = "Permissions.Products.Edit";
            public const string Delete = "Permissions.Products.Delete";
        }
        public static class Project
        {
            public const string View = "Permissions.Project.View";
            public const string Create = "Permissions.Project.Create";
            public const string Edit = "Permissions.Project.Edit";
            public const string Delete = "Permissions.Project.Delete";
        }
        public static class Services
        {
            public const string View = "Permissions.Services.View";
            public const string Create = "Permissions.Services.Create";
            public const string Edit = "Permissions.Services.Edit";
            public const string Delete = "Permissions.Services.Delete";

           
        }
        public static class Blogs
        {
            public const string View = "Permissions.Blogs.View";
            public const string Create = "Permissions.Blogs.Create";
            public const string Edit = "Permissions.Blogs.Edit";
            public const string Delete = "Permissions.Blogs.Delete";
        }
        public static class Jobs
        {
            public const string View = "Permissions.Jobs.View";
            public const string Create = "Permissions.Jobs.Create";
            public const string Edit = "Permissions.Jobs.Edit";
            public const string Delete = "Permissions.Jobs.Delete";
        }
    }
}