//--------------------------------------------------------------------------------------------------------------------
// Author: Carlos Daniel Angulo López (SpartanX10000)
// Project: PlusTag
// Class: TagCollection.cs
// Description: This class contains the main functions of the library.
//--------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;

namespace PlusTags.Standard
{
    public class TagCollection
    {    
        /// <summary>
        /// Obtains the string value of the specified tag.
        /// </summary>
        public static string Value(string id)
        {
            string text = string.Empty;
            try
            {
                List<Tag> Tags = TagUtilities.GetTags();
                Tag tag = Tags.Find(x => x.Id == id);
                if (tag == null)
                {
                    return string.Empty;
                }
                text = (tag.Value.Count > 0 ? tag.Value.ElementAt(0).Text : string.Empty);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return text;
        }

        /// <summary>
        /// Obtains the string value of the specified tag and language.
        /// </summary>
        public static string Value(string id, string language)
        {
            string text = string.Empty;
            try
            {
                List<Tag> Tags = TagUtilities.GetTags();
                Tag tag = Tags.Find(x => x.Id == id);
                if (tag == null)
                {
                    return string.Empty;
                }
                List<Value> values = tag.Value;
                Value value = values.Find(x => x.Language == language);
                text = (value != null ? value.Text : string.Empty);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return text;
        }
    }
}
