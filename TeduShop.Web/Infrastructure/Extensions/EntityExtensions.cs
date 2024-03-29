﻿using TeduShop.Model.Models;
using TeduShop.Web.Models;

namespace TeduShop.Web.Infrastructure.Extensions
{
    public static class EntityExtensions
    {
        public static void UpdatePostCategory(this PostCategory postCategory, PostCategoryViewModel postCategoryVm)
        {
            postCategory.Id = postCategoryVm.Id;
            postCategory.Name = postCategoryVm.Name;
            postCategory.Description = postCategoryVm.Description;
            postCategory.Alias = postCategoryVm.Alias;
            postCategory.ParentId = postCategoryVm.ParentId;
            postCategory.DisplayOrder = postCategoryVm.DisplayOrder;
            postCategory.Image = postCategoryVm.Image;
            postCategory.HomeFlag = postCategoryVm.HomeFlag;

            postCategory.CreatedDate = postCategoryVm.CreatedDate;
            postCategory.CreatedBy = postCategoryVm.CreatedBy;
            postCategory.UpdatedDate = postCategoryVm.UpdatedDate;
            postCategory.UpdatedBy = postCategoryVm.UpdatedBy;
            postCategory.MetaKeyword = postCategoryVm.MetaKeyword;
            postCategory.MetaDescription = postCategoryVm.MetaDescription;
            postCategory.Status = postCategoryVm.Status;
        }

        public static void UpdatePost(this Post post, PostViewModel postVm)
        {
            post.Id = postVm.Id;
            post.Name = postVm.Name;
            post.Description = postVm.Description;
            post.Alias = postVm.Alias;
            post.CategoryId = postVm.CategoryId;
            post.Content = postVm.Content;
            post.Image = postVm.Image;
            post.HomeFlag = postVm.HomeFlag;
            post.ViewCount = postVm.ViewCount;

            post.CreatedDate = postVm.CreatedDate;
            post.CreatedBy = postVm.CreatedBy;
            post.UpdatedDate = postVm.UpdatedDate;
            post.UpdatedBy = postVm.UpdatedBy;
            post.MetaKeyword = postVm.MetaKeyword;
            post.MetaDescription = postVm.MetaDescription;
            post.Status = postVm.Status;
        }

        //public static void UpdateProductCategory(this ProductCategory productCategory, ProductCategoryViewModel productCategoryVm)
        //{
        //    productCategory.Id = productCategoryVm.ID;
        //    productCategory.Name = productCategoryVm.Name;
        //    productCategory.Description = productCategoryVm.Description;
        //    productCategory.Alias = productCategoryVm.Alias;
        //    productCategory.ParentID = productCategoryVm.ParentID;
        //    productCategory.DisplayOrder = productCategoryVm.DisplayOrder;
        //    productCategory.Image = productCategoryVm.Image;
        //    productCategory.HomeFlag = productCategoryVm.HomeFlag;

        //    productCategory.CreatedDate = productCategoryVm.CreatedDate;
        //    productCategory.CreatedBy = productCategoryVm.CreatedBy;
        //    productCategory.UpdatedDate = productCategoryVm.UpdatedDate;
        //    productCategory.UpdatedBy = productCategoryVm.UpdatedBy;
        //    productCategory.MetaKeyword = productCategoryVm.MetaKeyword;
        //    productCategory.MetaDescription = productCategoryVm.MetaDescription;
        //    productCategory.Status = productCategoryVm.Status;

        //}

        //public static void UpdateProduct(this Product product, ProductViewModel productVm)
        //{
        //    product.Id = productVm.ID;
        //    product.Name = productVm.Name;
        //    product.Description = productVm.Description;
        //    product.Alias = productVm.Alias;
        //    product.CategoryID = productVm.CategoryID;
        //    product.Content = productVm.Content;
        //    product.Image = productVm.Image;
        //    product.MoreImages = productVm.MoreImages;
        //    product.Price = productVm.Price;
        //    product.PromotionPrice = productVm.PromotionPrice;
        //    product.Warranty = productVm.Warranty;
        //    product.HomeFlag = productVm.HomeFlag;
        //    product.HotFlag = productVm.HotFlag;
        //    product.ViewCount = productVm.ViewCount;

        //    product.CreatedDate = productVm.CreatedDate;
        //    product.CreatedBy = productVm.CreatedBy;
        //    product.UpdatedDate = productVm.UpdatedDate;
        //    product.UpdatedBy = productVm.UpdatedBy;
        //    product.MetaKeyword = productVm.MetaKeyword;
        //    product.MetaDescription = productVm.MetaDescription;
        //    product.Status = productVm.Status;
        //    product.Tags = productVm.Tags;
        //    product.Quantity = productVm.Quantity;
        //    product.OriginalPrice = productVm.OriginalPrice;
        //}

        //public static void UpdateFeedback(this Feedback feedback, FeedbackViewModel feedbackVm)
        //{
        //    feedback.Name = feedbackVm.Name;
        //    feedback.Email = feedbackVm.Email;
        //    feedback.Message = feedbackVm.Message;
        //    feedback.Status = feedbackVm.Status;
        //    feedback.CreatedDate = DateTime.Now;
        //}

        //public static void UpdateOrder(this Order order, OrderViewModel orderVm)
        //{
        //    order.CustomerName = orderVm.CustomerName;
        //    order.CustomerAddress = orderVm.CustomerName;
        //    order.CustomerEmail = orderVm.CustomerName;
        //    order.CustomerMobile = orderVm.CustomerName;
        //    order.CustomerMessage = orderVm.CustomerName;
        //    order.PaymentMethod = orderVm.CustomerName;
        //    order.CreatedDate = DateTime.Now;
        //    order.CreatedBy = orderVm.CreatedBy;
        //    order.Status = orderVm.Status;
        //    order.CustomerId = orderVm.CustomerId;
        //}

        //public static void UpdateApplicationGroup(this ApplicationGroup appGroup, ApplicationGroupViewModel appGroupViewModel)
        //{
        //    appGroup.Id = appGroupViewModel.Id  ;
        //    appGroup.Name = appGroupViewModel.Name;
        //}

        //public static void UpdateApplicationRole(this ApplicationRole appRole, ApplicationRoleViewModel appRoleViewModel, string action = "add")
        //{
        //    if (action == "update")
        //        appRole.Id = appRoleViewModel.Id;
        //    else
        //        appRole.Id = Guid.NewGuid().ToString();
        //    appRole.Name = appRoleViewModel.Name;
        //    appRole.Description = appRoleViewModel.Description;
        //}
        //public static void UpdateUser(this ApplicationUser appUser, ApplicationUserViewModel appUserViewModel, string action = "add")
        //{
        //    appUser.Id = appUserViewModel.Id;
        //    appUser.FullName = appUserViewModel.FullName;
        //    appUser.BirthDay = appUserViewModel.BirthDay;
        //    appUser.Email = appUserViewModel.Email;
        //    appUser.UserName = appUserViewModel.UserName;
        //    appUser.PhoneNumber = appUserViewModel.PhoneNumber;
        //}
    }
}