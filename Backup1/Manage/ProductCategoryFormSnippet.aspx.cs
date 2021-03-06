﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DotNet.EnterpriseWebSite.Manage
{
    using DotNet.ContentManagement.Contract.Entity;
    using DotNet.ContentManagement.Contract.IService;
    using DotNet.ContentManagement.Service;

    public partial class ProductCategoryFormSnippet : PageBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected string Id
        {
            get
            {
                return Request.QueryString["id"];
            }
        }

        private IProductCategoryService productCategoryService = new ProductCategoryService();

        private ProductCategoryInfo _category;

        public ProductCategoryInfo Category
        {
            get
            {
                int id;
                if (_category==null)
                {
                    if (int.TryParse(Id, out id))
                    {
                        _category= productCategoryService.GetProductCategoryById(id);
                    }
                }

                return _category;
            }
        }
    }
}