using AboutEG.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AboutEG.ViewModels;

namespace AboutEG.Utils
{
    public class ClassPostConverter
    {

        
        public static List<PostIndexViewModel> ConvertListPostsToListPostIndexViewModel(List<Post> posts)
        {
            List<PostIndexViewModel> postViewModel = new List<PostIndexViewModel>();
            foreach (var post in posts)
            {
                PostIndexViewModel postIndexViewModel = ConvertPostToPostIndexViewModel(post);
                postViewModel.Add(postIndexViewModel);

            }

            return postViewModel;

        }

        public static PostIndexViewModel ConvertPostToPostIndexViewModel(Post post)
        {

            PostIndexViewModel postIndexViewModel = new PostIndexViewModel();
            postIndexViewModel.Id = post.Id;
            postIndexViewModel.SubTitle = post.SubTitle;
            postIndexViewModel.Title = post.Title;
            postIndexViewModel.PublishDate = post.PublishDate;
            postIndexViewModel.IsProvisional = post.IsProvisional;
            postIndexViewModel.SlugUrl = post.SlugUrl;
           // postIndexViewModel.Tags = ClassTagConverter.ConvertListTagsToListTagIndexViewModel(post.Tags.ToList());
            postIndexViewModel.PostDate = post.PostDate;
            postIndexViewModel.Ahutor = post.Ahutor;
            postIndexViewModel.HtmlContent = post.HtmlContent;

            return postIndexViewModel;

        }

        public static PostCreateViewModel ConvertPostToPostCreateViewModel(Post post)
        {

            PostCreateViewModel postCreateViewModel = new PostCreateViewModel();
            postCreateViewModel.Id = post.Id;
            postCreateViewModel.SubTitle = post.SubTitle;
            postCreateViewModel.Title = post.Title;
            postCreateViewModel.PublishDate = post.PublishDate;
            postCreateViewModel.IsProvisional = post.IsProvisional;
            postCreateViewModel.SlugUrl = post.SlugUrl;
          //  postCreateViewModel.Tags = ClassTagConverter.ConvertListTagsToListTagCreateViewModel(post.Tags.ToList());
            postCreateViewModel.PostDate = post.PostDate;
            postCreateViewModel.Ahutor = post.Ahutor;
            postCreateViewModel.HtmlContent = post.HtmlContent;

            return postCreateViewModel;

        }

        public static Post  ConvertPostCreateViewModelToPost(PostCreateViewModel postCreateViewModel)
        {

            Post post = new Post();
            post.Id = postCreateViewModel.Id;
            post.SubTitle = postCreateViewModel.SubTitle;
            post.Title = postCreateViewModel.Title;
            post.PublishDate = postCreateViewModel.PublishDate;
            post.IsProvisional = postCreateViewModel.IsProvisional;
            post.SlugUrl = postCreateViewModel.SlugUrl;
            //post.Tags = postCreateViewModel.Tags;
            post.PostDate = postCreateViewModel.PostDate;
            post.Ahutor = postCreateViewModel.Ahutor;
            post.HtmlContent = postCreateViewModel.HtmlContent;

            return post;

        }



        public static PostDetailViewModel ConvertPostToPostDetailViewModel(Post post)
        {

            PostDetailViewModel postDetailViewModel = new PostDetailViewModel();
            postDetailViewModel.Id = post.Id;
            postDetailViewModel.SubTitle = post.SubTitle;
            postDetailViewModel.Title = post.Title;
            postDetailViewModel.PublishDate = post.PublishDate;
            postDetailViewModel.IsProvisional = post.IsProvisional;
            postDetailViewModel.SlugUrl = post.SlugUrl;
           // postDetailViewModel.Tags =  post.Tags;
            postDetailViewModel.PostDate = post.PostDate;
            postDetailViewModel.Ahutor = post.Ahutor;
            postDetailViewModel.HtmlContent = post.HtmlContent;

            return postDetailViewModel;

        }

        public static Post ConvertPostDetailViewModelToPost(PostDetailViewModel postDetailViewModel)
        {

            Post post = new Post();
            post.Id = postDetailViewModel.Id;
            post.SubTitle = postDetailViewModel.SubTitle;
            post.Title = postDetailViewModel.Title;
            post.PublishDate = postDetailViewModel.PublishDate;
            post.IsProvisional = postDetailViewModel.IsProvisional;
            post.SlugUrl = postDetailViewModel.SlugUrl;
            //post.Tags = postDetailViewModel.Tags;
            post.PostDate = postDetailViewModel.PostDate;
            post.Ahutor = postDetailViewModel.Ahutor;
            post.HtmlContent = postDetailViewModel.HtmlContent;

            return post;

        }



        public static PostEditViewModel ConvertPostToPostEditViewModel(Post post)
        {

            PostEditViewModel postEditViewModel = new PostEditViewModel();
            postEditViewModel.Id = post.Id;
            postEditViewModel.SubTitle = post.SubTitle;
            postEditViewModel.Title = post.Title;
            postEditViewModel.PublishDate = post.PublishDate;
            postEditViewModel.IsProvisional = post.IsProvisional;
            postEditViewModel.SlugUrl = post.SlugUrl;
           // postEditViewModel.Tags = post.Tags;
            postEditViewModel.PostDate = post.PostDate;
            postEditViewModel.Ahutor = post.Ahutor;
            postEditViewModel.HtmlContent = post.HtmlContent;

            return postEditViewModel;

        }

        public static Post ConvertPostEditViewModelToPost(PostEditViewModel postEditViewModel)
        {

            Post post = new Post();
            post.Id = postEditViewModel.Id;
            post.SubTitle = postEditViewModel.SubTitle;
            post.Title = postEditViewModel.Title;
            post.PublishDate = postEditViewModel.PublishDate;
            post.IsProvisional = postEditViewModel.IsProvisional;
            post.SlugUrl = postEditViewModel.SlugUrl;
           // post.Tags = postEditViewModel.Tags;
            post.PostDate = postEditViewModel.PostDate;
            post.Ahutor = postEditViewModel.Ahutor;
            post.HtmlContent = postEditViewModel.HtmlContent;

            return post;

        }



        public static PostDeleteViewModel ConvertPostsToPostDeleteViewModel(Post post)
        {

            PostDeleteViewModel postDeleteViewModel = new PostDeleteViewModel();
            postDeleteViewModel.Id = post.Id;
            postDeleteViewModel.SubTitle = post.SubTitle;
            postDeleteViewModel.Title = post.Title;
            postDeleteViewModel.PublishDate = post.PublishDate;
            postDeleteViewModel.IsProvisional = post.IsProvisional;
            postDeleteViewModel.SlugUrl = post.SlugUrl;
           // postDeleteViewModel.Tags = post.Tags;
            postDeleteViewModel.PostDate = post.PostDate;
            postDeleteViewModel.Ahutor = post.Ahutor;
            postDeleteViewModel.HtmlContent = post.HtmlContent;

            return postDeleteViewModel;

        }
    }
}