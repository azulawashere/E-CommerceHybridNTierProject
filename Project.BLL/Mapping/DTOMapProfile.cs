using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Project.BLL.DTOClasses;
using Project.ENTITES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.Mapping
{
    public class DTOMapProfile : Profile
    {
        public DTOMapProfile()
        {
            #region ProductDTOMapping
            CreateMap<Product, ProductDTO>()
                .ForMember(dest => dest.ProductName, act => act.MapFrom(src => src.ProductName))
                .ForMember(dest => dest.UnitPrice, act => act.MapFrom(src => src.UnitPrice))
                .ForMember(dest => dest.UnitsInStock, act => act.MapFrom(src => src.UnitInStock))
                .ForMember(dest => dest.ImagePath, act => act.MapFrom(src => src.ImagePath))
                .ForMember(dest => dest.CategoryID, act => act.MapFrom(src => src.CategoryID))
                .ForMember(dest => dest.CreatedDate, act => act.MapFrom(src => src.CreatedDate))
                .ForMember(dest => dest.ModifiedDate, act => act.MapFrom(src => src.ModifiedDate))
                .ForMember(dest => dest.DeletedDate, act => act.MapFrom(src => src.DeletedDate))
                .ForMember(dest => dest.Category, act => act.MapFrom(src => src.Category))
                .ReverseMap();
            #endregion
            #region CategoryDTOMapping

            CreateMap<Category, CategoryDTO>()
                .ForMember(dest => dest.CategoryName, act => act.MapFrom(src => src.CategoryName))
                .ForMember(dest => dest.Description, act => act.MapFrom(src => src.Description))
                .ForMember(dest => dest.CreatedDate, act => act.MapFrom(src => src.CreatedDate))
                .ForMember(dest => dest.ModifiedDate, act => act.MapFrom(src => src.ModifiedDate))
                .ForMember(dest => dest.DeletedDate, act => act.MapFrom(src => src.DeletedDate))
                .ReverseMap();
            #endregion

            #region OrderDTOMapping
            CreateMap<Order, OrderDTO>()
                .ForMember(dest => dest.AppUserID, act => act.MapFrom(src => src.AppUserID))
                 .ForMember(dest => dest.ShippedAddress, act => act.MapFrom(src => src.ShippingAddress))
                 .ForMember(dest => dest.PriceOfOrder, act => act.MapFrom(src => src.PriceOfOrder))
                 .ForMember(dest => dest.Email, act => act.MapFrom(src => src.Email))
                 .ForMember(dest => dest.NameDescription, act => act.MapFrom(src => src.NameDescription))
                .ForMember(dest => dest.CreatedDate, act => act.MapFrom(src => src.CreatedDate))
                .ForMember(dest => dest.ModifiedDate, act => act.MapFrom(src => src.ModifiedDate))
                .ForMember(dest => dest.DeletedDate, act => act.MapFrom(src => src.DeletedDate))
                .ReverseMap();
            #endregion

            #region OrderProductDTOMapping

            CreateMap<OrderDetail, OrderDetailDTO>()
                .ForMember(dest => dest.OrderID, act => act.MapFrom(src => src.OrderID))
                .ForMember(dest => dest.Quantity, act => act.MapFrom(src => src.Quantity))
                .ForMember(dest => dest.UnitPrice, act => act.MapFrom(src => src.UnitPrice))
                .ForMember(dest => dest.ProductID, act => act.MapFrom(src => src.ProductID))
                .ForMember(dest => dest.CreatedDate, act => act.MapFrom(src => src.CreatedDate))
                .ForMember(dest => dest.ModifiedDate, act => act.MapFrom(src => src.ModifiedDate))
                .ForMember(dest => dest.DeletedDate, act => act.MapFrom(src => src.DeletedDate))
                .ReverseMap();
            #endregion

            #region AppUserDTOMapping

            CreateMap<AppUser, AppUserDTO>()
                .ForMember(dest => dest.UserName, act => act.MapFrom(src => src.UserName))
                .ForMember(dest => dest.UserPassword, act => act.MapFrom(src => src.PasswordHash))
                .ForMember(dest => dest.CreatedDate, act => act.MapFrom(src => src.CreatedDate))
                .ForMember(dest => dest.ModifiedDate, act => act.MapFrom(src => src.ModifiedDate))
                .ForMember(dest => dest.DeletedDate, act => act.MapFrom(src => src.DeletedDate))
                .ReverseMap();
            #endregion

            #region UserProfileDTOMapping

            CreateMap<AppUserProfile, UserProfileDTO>()
                .ForMember(dest => dest.FirstName, act => act.MapFrom(src => src.FirstName))
                .ForMember(dest => dest.LastName, act => act.MapFrom(src => src.LastName))
                .ForMember(dest => dest.CreatedDate, act => act.MapFrom(src => src.CreatedDate))
                .ForMember(dest => dest.ModifiedDate, act => act.MapFrom(src => src.ModifiedDate))
                .ForMember(dest => dest.DeletedDate, act => act.MapFrom(src => src.DeletedDate))
                .ReverseMap();
            #endregion

           
        }
    }
}
