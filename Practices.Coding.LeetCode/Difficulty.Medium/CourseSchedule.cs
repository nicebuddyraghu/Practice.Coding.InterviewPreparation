using System;
using System.Collections.Generic;

namespace Practices.Coding.LeetCode.Difficulty.Medium
{
    public class CourseSchedule
    {
        /***
         * 
         * https://leetcode.com/problems/course-schedule/
         * 
         * 
         */
        public class Solution
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

            Stack<int> coursestack = new Stack<int>();
            public bool CanFinish(int numCourses, int[][] prerequisites)
            {

                CourseGraph coursegraph = new CourseGraph(numCourses, prerequisites);

                bool[] coursesTaken = new bool[numCourses];

                for (int course = 0; course < numCourses; course++)
                {
                    coursesTaken = new bool[numCourses];
                    if (IsCyclic(coursegraph, course, coursesTaken)) return false;
                }

                Console.WriteLine("Break");
                for (int course = 0; course < numCourses; course++)
                {
                    coursesTaken[course] = false;
                }

                int totalcoursestaken = 0;
                for (int course = 0; course < numCourses; course++)
                {
                    if (coursesTaken[course] == false)
                    {
                        totalcoursestaken += Dfs(coursegraph, 0, coursesTaken);
                    }
                }

                return totalcoursestaken == numCourses;
            }

            public int Dfs(CourseGraph courseGraph, int course, bool[] coursesTaken)
            {
                coursesTaken[course] = true;
                int coursescount = 1;
                var nextcourselist = courseGraph.NextCourseList[course];
                foreach (var nextcourse in nextcourselist)
                {
                    if (coursesTaken[nextcourse] == false)
                    {
                        coursescount += Dfs(courseGraph, nextcourse, coursesTaken);
                    }
                }

                return coursescount;
            }


        }
    }
}
