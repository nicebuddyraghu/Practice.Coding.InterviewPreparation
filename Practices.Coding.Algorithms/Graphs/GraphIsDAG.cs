using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices.Coding.Algorithms.Graphs
{
    public class GraphIsDAG
    {
        public class CourseGraph
        {

            public CourseGraph(int courses, int[][] prerequisites)
            {
                Courses = courses;
                NextCourseList = new List<List<int>>();

                for (int course = 0; course < courses; course++)
                {
                    NextCourseList.Add(new List<int>());
                }

                for (int row = 0; row < prerequisites.Length; row++)
                {
                    int prerequisitecourse = prerequisites[row][0];
                    int nextcourse = prerequisites[row][1];
                    NextCourseList[prerequisitecourse].Add(nextcourse);
                }
            }

            public int Courses { get; set; }
            public List<List<int>> NextCourseList { get; set; }
        }

        System.Collections.Generic.Dictionary<int, bool> cyclictable = new System.Collections.Generic.Dictionary<int, bool>();
        public bool IsCyclic(CourseGraph graph, int course, bool[] coursesTaken)
        {
            if (coursesTaken[course] == true)
            {
                return true;
            }
            else
            {
                coursesTaken[course] = true;
            }

            foreach (var nextcourse in graph.NextCourseList[course])
            {
                if (!cyclictable.ContainsKey(nextcourse))
                {
                    if (IsCyclic(graph, nextcourse, coursesTaken))
                    {
                        return true;
                    }
                }
            }

            if (!cyclictable.ContainsKey(course))
            {
                cyclictable.Add(course, false);
            }
            coursesTaken[course] = false;

            return false;
        }

        public bool IsGraphAcyclic(int numCourses, int[][] prerequisites)
        {

            CourseGraph coursegraph = new CourseGraph(numCourses, prerequisites);

            bool[] coursesTaken = new bool[numCourses];

            for (int course = 0; course < numCourses; course++)
            {
                coursesTaken = new bool[numCourses];
                if (IsCyclic(coursegraph, course, coursesTaken)) return false;
            }

            return true;
        }
    }
}
