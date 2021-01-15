using Sitecore.Data;
using Sitecore.Data.Fields;
using Sitecore.Data.Items;
using Sitecore.Mvc.Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FordIndia.Feature.FAQ.Models
{
    public class FAQ
    {
        public List<Item> FAQfilterList { get; set; }
        //public List<Item> CategoryList { get; set; }
        public List<FAQItems> FAQList { get; set; }
        public Item CurrentItem { get; set; }
        public FAQ()
        {
            Database currentDB = Sitecore.Context.Database;
            Item CurrentItem = RenderingContext.Current.Rendering.Item;
            Item faqfilterFolder = currentDB.GetItem(FolderID.FAQFiltersID);
            Item FaqContentFolder = currentDB.GetItem(FolderID.FAQsID);
            FAQfilterList = getFAQFilters(faqfilterFolder);           
            FAQList = getFAQList(FaqContentFolder,FAQfilterList);
        }
        public List<Item> getFAQFilters(Item filterFolder)
        {
            if (filterFolder == null || !filterFolder.HasChildren)
                return null;

            List<Item> decendantLIst = filterFolder.Axes.GetDescendants().Where(x => x.TemplateID == Templates.FAQFilterItems.ID).ToList();
            List<Item> filterList = new List<Item>();
            foreach (Item currentItem in decendantLIst)
            {
                CheckboxField isParent = currentItem.Fields[Templates.FAQFilterItems.Fields.Isparent];
                if (isParent != null && isParent.Checked)
                {
                    filterList.Add(currentItem);
                }
            }
            return filterList;
        }
        public List<FAQItems> getFAQList(Item faqFolder,List<Item> FilterList)
        {
            List<FAQItems> allFaqItems = new List<FAQItems>();
            List<Item> allItems = faqFolder.Axes.GetDescendants().Where(x => x.TemplateID.Equals(Templates.FAQ.ID)).ToList();
            foreach (Item filterList in FilterList)
            {
                FAQItems FaqItems = new FAQItems();
                List<Item> filterFaq = new List<Item>();
                foreach (Item faq in allItems)
                {
                    MultilistField filterField = faq.Fields[Templates.FAQ.Fields.FAQFilter];
                    List<Item> listItems = filterField.GetItems().ToList();
                    foreach (Item item in listItems)
                    {
                        if (filterList.Name.Equals(item.Name))
                        {
                            filterFaq.Add(faq);
                        }
                    }
                    
                }
                FaqItems.FAQFilter = filterList;
                FaqItems.FAQ = filterFaq;
                allFaqItems.Add(FaqItems);
            }
            return allFaqItems;
        }
        
    }
    public class FAQItems
    {
        public Item FAQFilter;
        public List<Item> FAQ;

    }
}