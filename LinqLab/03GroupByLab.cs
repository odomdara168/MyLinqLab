using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLab
{

    public class GroupByLab
    {
        private static IEnumerable<Sample> Source { get; set; }
        public GroupByLab()
        {
            Source = new SampleDate().GetData();
        }
        public IList<IGrouping<string, Sample>> GroupByUserName()
        {
            var result = Source.GroupBy(sample => sample.UserName);
            return result.ToList();
        }

        public IEnumerable<IGrouping<TempObj, Sample>> GroupByUserNameAndCreateTime()
        {
            var result = Source.GroupBy(sample=> new TempObj
            {
                UserName = d.UserName,
                CreateTime = d.CreateTime
            });
            return result;
        }
    }
}
