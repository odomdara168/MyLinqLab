using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLab
{
   public class FirstAndSingleLab
    {
        private static IEnumerable<Sample> Source { get; set; }

        public FirstAndSingleLab()
        {
            Source = new SampleDate().GetData();
        }

        public Sample FirstToGetUserNameEqualToDemo()
        {
            var result = Source.First(sample => sample.UserName == "demo");
            
            return result;
        }

        public Sample? FirstOrDefaultToGetUserNameEuqalToSkilltree()
        {
            var result = Source.FirstOrDefault(sample => sample.UserName == "skilltree");
            return result;
        }

        public Sample FirstToGetUserNameEuqalToSkilltree()
        {
            var result =  Source.First(sample => sample.UserName == "skilltree");
            return result;
        }

        public Sample SingleToGetUserNameEuqalToDemo()
        {
            var result = Source.Single(sample => sample.UserName == "demo");
            return result;
        }

        public Sample SingleToGetUserNameEuqalToBill()
        {
            var result = Source.Single(sample => sample.UserName == "bill");
            return result;
        }
        public Sample? SingleOrDefaultToGetUserNameEuqalToBill()
        {
            var result = Source.SingleOrDefault(sample => sample.UserName == "bill");
            return result;
        }

        public Sample? SingleOrDefaultToGetUserNameEuqalToSkillTree()
        {
            var result = Source.SingleOrDefault(sample => sample.UserName == "skilltree");
            return result;
        }
    }
}
