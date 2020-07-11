using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AboutEG.Models;
using AboutEG.ViewModels;

namespace AboutEG.Utils
{
    public class ClassTagConverter
    {

        public static List<TagIndexViewModel> ConvertListTagsToListTagIndexViewModel(List<Tag> tags)
        {
            List<TagIndexViewModel> tagViewModel = new List<TagIndexViewModel>();
            foreach (var tag in tags)
            {
                TagIndexViewModel tagIndexViewModel = ConvertTagToTagIndexViewModel(tag);
                tagViewModel.Add(tagIndexViewModel);

            }

            return tagViewModel;

        }

        public static TagIndexViewModel ConvertTagToTagIndexViewModel(Tag tag)
        {

            TagIndexViewModel tagIndexViewModel = new TagIndexViewModel();
            tagIndexViewModel.Id = tag.Id;
            tagIndexViewModel.Name = tag.Name;
            tagIndexViewModel.SlugUrl = tag.SlugUrl;
            tagIndexViewModel.Posts = ClassPostConverter.ConvertListPostsToListPostIndexViewModel(tag.Posts.ToList());


            return tagIndexViewModel;

        }

        public static List<TagCreateViewModel> ConvertListTagsToListTagCreateViewModel(List<Tag> tags)
        {
            List<TagCreateViewModel> tagViewModel = new List<TagCreateViewModel>();
            foreach (var tag in tags)
            {
                TagCreateViewModel tagCreateViewModel = ConvertTagToTagCreateViewModel(tag);
                tagViewModel.Add(tagCreateViewModel);

            }

            return tagViewModel;

        }

        public static TagCreateViewModel ConvertTagToTagCreateViewModel(Tag tag)
        {
            TagCreateViewModel tagCreateViewModel = new TagCreateViewModel();
            tagCreateViewModel.Id = tag.Id;
            tagCreateViewModel.Name = tag.Name;
            tagCreateViewModel.SlugUrl = tag.SlugUrl;

            return tagCreateViewModel;

        }

        public static Tag ConvertTagCreateViewModelToTag(TagCreateViewModel tagCreateViewModel)
        {

            Tag tag = new Tag();
            tag.Id = tagCreateViewModel.Id;
            tag.Name = tagCreateViewModel.Name;
            tag.SlugUrl = tagCreateViewModel.SlugUrl;


            return tag;

        }


        public static List<TagDetailViewModel> ConvertListTagsToListTagDetailViewModel(List<Tag> tags)
        {
            List<TagDetailViewModel> tagViewModel = new List<TagDetailViewModel>();
            foreach (var tag in tags)
            {
                TagDetailViewModel tagDetailViewModel = ConvertTagToTagDetailViewModel(tag);
                tagViewModel.Add(tagDetailViewModel);

            }

            return tagViewModel;

        }

        public static TagDetailViewModel ConvertTagToTagDetailViewModel(Tag tag)
        {

            TagDetailViewModel tagDetailViewModel = new TagDetailViewModel();
            tagDetailViewModel.Id = tag.Id;
            tagDetailViewModel.Name = tag.Name;
            tagDetailViewModel.SlugUrl = tag.SlugUrl;


            return tagDetailViewModel;

        }

        public static Tag ConvertTagDetailViewModelToTag(TagDetailViewModel tagDetailViewModel)
        {

            Tag tag = new Tag();
            tag.Id = tagDetailViewModel.Id;
            tag.Name = tagDetailViewModel.Name;
            tag.SlugUrl = tagDetailViewModel.SlugUrl;


            return tag;

        }


        public static TagEditViewModel ConvertTagToTagEditViewModel(Tag tag)
        {

            TagEditViewModel tagEditViewModel = new TagEditViewModel();
            tagEditViewModel.Id = tag.Id;
            tagEditViewModel.Name = tag.Name;
            tagEditViewModel.SlugUrl = tag.SlugUrl;
            //  tagEditViewModel.Posts = ClassPostConverter.ConvertListPostsToListPostEditViewModel(tag.Posts.ToList());


            return tagEditViewModel;

        }



        public static Tag ConvertTagEditViewModelToTag(TagEditViewModel tagEditViewModel)
        {

            Tag tag = new Tag();
            tag.Id = tagEditViewModel.Id;
            tag.Name = tagEditViewModel.Name;
            tag.SlugUrl = tagEditViewModel.SlugUrl;

            return tag;

        }



        public static TagDeleteViewModel ConvertTagsToTagDeleteViewModel(Tag tag)
        {

            TagDeleteViewModel tagDeleteViewModel = new TagDeleteViewModel();
            tagDeleteViewModel.Id = tag.Id;
            tagDeleteViewModel.Name = tag.Name;
            tagDeleteViewModel.SlugUrl = tag.SlugUrl;


            return tagDeleteViewModel;

        }
    }
}