using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using System.Collections;

namespace MunicipalServiceApplication
{
    public partial class LocalEventsForm : Form
    {
        // Queue to manage upcoming events
        private Queue<Event> upcomingEvents = new Queue<Event>();
        private PriorityQueue<Event, int> priorityEvents =
        new PriorityQueue<Event, int>();
        //Stack to store recent user searches
        private Stack<string> recentSearches =
            new Stack<string>();

        // SortedDictionary to organise events by date
        private SortedDictionary<DateTime, List<Event>> eventsByDate =
            new SortedDictionary<DateTime, List<Event>>();
       
        // HashSet to store unique event categories
        private HashSet<string> eventCategories =
            new HashSet<string>();

        // Dictionary to track user search preferences
        private Dictionary<string, int> searchHistory =
            new Dictionary<string, int>();

        //Hash Table to quickly look up events by name
        private Hashtable eventHashTable =
            new Hashtable();

        public LocalEventsForm()
        {
            InitializeComponent();
            btnSearch.Click += btnSearch_Click;
            btnShowAll.Click += btnShowAll_Click;
            btnBack.Click += btnBack_Click;

            LoadEvents();
            LoadCategories();
            DisplayAllEvents();
        }

        private void LoadEvents()
        {
            List<Event> events = new List<Event>
    {
        new Event(
            "Community Clean-up Day",
            "Community",
            new DateTime(2026, 9, 20),
            "Community Park",
            "Residents are invited to participate in a community clean-up day."
        ),

        new Event(
            "Youth Career Workshop",
            "Education",
            new DateTime(2026, 9, 25),
            "Municipal Community Hall",
            "A career workshop providing guidance and opportunities for young people."
        ),

        new Event(
            "Local Food Festival",
            "Culture",
            new DateTime(2026, 10, 3),
            "Town Centre",
            "A local food festival celebrating food and culture from the community."
        ),

        new Event(
            "Municipal Sports Day",
            "Sports",
            new DateTime(2026, 10, 10),
            "Municipal Sports Ground",
            "A day of sports and recreational activities for community members."
        ),

        new Event(
            "Small Business Information Session",
            "Business",
            new DateTime(2026, 10, 17),
            "Municipal Offices",
            "An information session for residents interested in starting a small business."
        )
    };

            foreach (Event currentEvent in events)
            {
                // Add event to the Queue
                upcomingEvents.Enqueue(currentEvent);

                // Add event to the Priority Queue
                int priority = 3;

                if (currentEvent.Category == "Community")
                {
                    priority = 1;
                }
                else if (currentEvent.Category == "Education")
                {
                    priority = 2;
                }
                else if (currentEvent.Category == "Business")
                {
                    priority = 2;
                }
                else if (currentEvent.Category == "Sports")
                {
                    priority = 3;
                }
                else if (currentEvent.Category == "Culture")
                {
                    priority = 4;
                }

                priorityEvents.Enqueue(currentEvent, priority);

                // Add event to the SortedDictionary
                if (!eventsByDate.ContainsKey(currentEvent.Date))
                {
                    eventsByDate[currentEvent.Date] = new List<Event>();
                }

                eventsByDate[currentEvent.Date].Add(currentEvent);

                // Add unique category to the HashSet
                eventCategories.Add(currentEvent.Category);

                // Add event to the Hash Table
                eventHashTable[currentEvent.Name] = currentEvent;
            }
        }
        

                    private void LoadCategories()
                    {
                        cmbCategory.Items.Clear();

                        cmbCategory.Items.Add("All Categories");

                        foreach (string category in eventCategories.OrderBy(c => c))
                        {
                            cmbCategory.Items.Add(category);
                        }

                        cmbCategory.SelectedIndex = 0;
                    } 
            
        private void DisplayAllEvents()
        {
            lstEvents.Items.Clear();

            foreach (KeyValuePair<DateTime, List<Event>> entry in eventsByDate)
            {
                foreach (Event currentEvent in entry.Value)
                {
                    lstEvents.Items.Add(
                        $"{currentEvent.Name} | {currentEvent.Category} | " +
                        $"{currentEvent.Date:dd MMMM yyyy} | {currentEvent.Location}"
                    );
                }
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string selectedCategory = cmbCategory.SelectedItem?.ToString() ?? "All Categories";
            DateTime selectedDate = dtpDate.Value.Date;

            lstEvents.Items.Clear();

            // Record the user's category search
            if (selectedCategory != "All Categories")
            {
                if (searchHistory.ContainsKey(selectedCategory))
                {
                    searchHistory[selectedCategory]++;
                }
                else
                {
                    searchHistory[selectedCategory] = 1;
                }

                // Store the search in the Stack
                recentSearches.Push(selectedCategory);
            }

            bool found = false;

            foreach (KeyValuePair<DateTime, List<Event>> entry in eventsByDate)
            {
                foreach (Event currentEvent in entry.Value)
                {
                    bool categoryMatches =
                        selectedCategory == "All Categories" ||
                        currentEvent.Category == selectedCategory;

                    bool dateMatches =
                        currentEvent.Date.Date == selectedDate;

                    if (categoryMatches && dateMatches)
                    {
                        lstEvents.Items.Add(
                            $"{currentEvent.Name} | {currentEvent.Category} | " +
                            $"{currentEvent.Date:dd MMMM yyyy} | {currentEvent.Location}"
                        );

                        found = true;
                    }
                }
            }

            if (!found)
            {
                lstEvents.Items.Add("No events found for the selected search.");
            }

            // Display recommendations after the search is complete
            DisplayRecommendations();
        }
        private void btnShowAll_Click(object sender, EventArgs e)
        {
            DisplayAllEvents();

        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void lblRecommendations_Click(object sender, EventArgs e)
        {

        }

        private void lstRecommendations_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstEvents_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void DisplayRecommendations()
        {
            lstRecommendations.Items.Clear();

            // If the user has not searched for a category yet
            if (searchHistory.Count == 0)
            {
                lstRecommendations.Items.Add(
                    "Search for an event category to receive recommendations."
                );
                return;
            }

            // Find the category searched for most often
            string mostSearchedCategory = "";
            int highestSearchCount = 0;

            foreach (KeyValuePair<string, int> search in searchHistory)
            {
                if (search.Value > highestSearchCount)
                {
                    mostSearchedCategory = search.Key;
                    highestSearchCount = search.Value;
                }
            }

            lstRecommendations.Items.Add(
                "Recommended events based on your searches:"
            );

            bool recommendationFound = false;

            foreach (KeyValuePair<DateTime, List<Event>> entry in eventsByDate)
            {
                foreach (Event currentEvent in entry.Value)
                {
                    if (currentEvent.Category == mostSearchedCategory)
                    {
                        lstRecommendations.Items.Add(
                            $"{currentEvent.Name} | {currentEvent.Category} | " +
                            $"{currentEvent.Date:dd MMMM yyyy} | {currentEvent.Location}"
                        );

                        recommendationFound = true;
                    }
                }
            }

            if (!recommendationFound)
            {
                lstRecommendations.Items.Add(
                    "No recommended events are available."
                );
            }
        }
    }
}
