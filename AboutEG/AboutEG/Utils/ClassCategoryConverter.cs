using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AboutEG.Models;
using AboutEG.ViewModels;

namespace AboutEG.Utils
{
    public class ClassCategoryConverter
    {
        public ClassCategoryConverter()
        {
        }

        public static List<CategoryIndexViewModel> ConvertListCategorysToListCategoryIndexViewModel(List<Category> categorys)
        {
            List<CategoryIndexViewModel> categoryViewModel = new List<CategoryIndexViewModel>();
            foreach (var category in categorys)
            {
                CategoryIndexViewModel categoryIndexViewModel = ConvertCategoryToCategoryIndexViewModel(category);
                categoryViewModel.Add(categoryIndexViewModel);

            }

            return categoryViewModel;

        }

        public static CategoryIndexViewModel ConvertCategoryToCategoryIndexViewModel(Category category)
        {

            CategoryIndexViewModel categoryIndexViewModel = new CategoryIndexViewModel();
            categoryIndexViewModel.Id = category.Id;
            categoryIndexViewModel.Name = category.Name;
            categoryIndexViewModel.SlugUrl = category.SlugUrl;
            categoryIndexViewModel.Posts = ClassPostConverter.ConvertListPostsToListPostIndexViewModel(category.Posts.ToList());


            return categoryIndexViewModel;

        }

        public static List<CategoryCreateViewModel> ConvertListCategorysToListCategoryCreateViewModel(List<Category> categorys)
        {
            List<CategoryCreateViewModel> categoryViewModel = new List<CategoryCreateViewModel>();
            foreach (var category in categorys)
            {
                CategoryCreateViewModel categoryCreateViewModel = ConvertCategoryToCategoryCreateViewModel(category);
                categoryViewModel.Add(categoryCreateViewModel);

            }

            return categoryViewModel;

        }

        public static CategoryCreateViewModel ConvertCategoryToCategoryCreateViewModel(Category category)
        {
            CategoryCreateViewModel categoryCreateViewModel = new CategoryCreateViewModel();
            categoryCreateViewModel.Id = category.Id;
            categoryCreateViewModel.Name = category.Name;
            categoryCreateViewModel.SlugUrl = category.SlugUrl;

            return categoryCreateViewModel;

        }

        public static Category ConvertCategoryCreateViewModelToCategory(CategoryCreateViewModel categoryCreateViewModel)
        {

            Category category = new Category();
            category.Id = categoryCreateViewModel.Id;
            category.Name = categoryCreateViewModel.Name;
            category.SlugUrl = categoryCreateViewModel.SlugUrl;


            return category;

        }


        public static List<CategoryDetailViewModel> ConvertListCategorysToListCategoryDetailViewModel(List<Category> categorys)
        {
            List<CategoryDetailViewModel> categoryViewModel = new List<CategoryDetailViewModel>();
            foreach (var category in categorys)
            {
                CategoryDetailViewModel categoryDetailViewModel = ConvertCategoryToCategoryDetailViewModel(category);
                categoryViewModel.Add(categoryDetailViewModel);

            }

            return categoryViewModel;

        }

        public static CategoryDetailViewModel ConvertCategoryToCategoryDetailViewModel(Category category)
        {

            CategoryDetailViewModel categoryDetailViewModel = new CategoryDetailViewModel();
            categoryDetailViewModel.Id = category.Id;
            categoryDetailViewModel.Name = category.Name;
            categoryDetailViewModel.SlugUrl = category.SlugUrl;


            return categoryDetailViewModel;

        }

        public static Category ConvertCategoryDetailViewModelToCategory(CategoryDetailViewModel categoryDetailViewModel)
        {

            Category category = new Category();
            category.Id = categoryDetailViewModel.Id;
            category.Name = categoryDetailViewModel.Name;
            category.SlugUrl = categoryDetailViewModel.SlugUrl;


            return category;

        }


        public static CategoryEditViewModel ConvertCategoryToCategoryEditViewModel(Category category)
        {

            CategoryEditViewModel categoryEditViewModel = new CategoryEditViewModel();
            categoryEditViewModel.Id = category.Id;
            categoryEditViewModel.Name = category.Name;
            categoryEditViewModel.SlugUrl = category.SlugUrl;
            //  categoryEditViewModel.Posts = ClassPostConverter.ConvertListPostsToListPostEditViewModel(category.Posts.ToList());


            return categoryEditViewModel;

        }



        public static Category ConvertCategoryEditViewModelToCategory(CategoryEditViewModel categoryEditViewModel)
        {

            Category category = new Category();
            category.Id = categoryEditViewModel.Id;
            category.Name = categoryEditViewModel.Name;
            category.SlugUrl = categoryEditViewModel.SlugUrl;

            return category;

        }



        public static CategoryDeleteViewModel ConvertCategorysToCategoryDeleteViewModel(Category category)
        {

            CategoryDeleteViewModel categoryDeleteViewModel = new CategoryDeleteViewModel();
            categoryDeleteViewModel.Id = category.Id;
            categoryDeleteViewModel.Name = category.Name;
            categoryDeleteViewModel.SlugUrl = category.SlugUrl;


            return categoryDeleteViewModel;

        }
    }
   
}