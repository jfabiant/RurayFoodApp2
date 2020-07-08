using RurayFoodApp2.Models.Catalog;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Xamarin.Forms.Internals;

namespace RurayFoodApp2.ViewModels.Catalog
{
    /// <summary>
    /// ViewModel for event list page.
    /// </summary>
    [Preserve(AllMembers = true)]
    [DataContract]
    public class EventListViewModel : BaseViewModel
    {
        #region Fields

        private List<EventList> eventItems;

        private List<EventList> popularEventItems;

        private List<EventList> upcomingEventItems;

        public int selectedIndex;

        public string searchText;

        public string allListSearchText;

        public string upcomingListSearchText;

        public string popularListSearchText;

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance for the <see cref="EventListViewModel" /> class.
        /// </summary>

        public EventListViewModel()
        {
            this.EventItems = new List<EventList>()
            {
                 new EventList { ImagePath = "https://images-gmi-pmc.edge-generalmills.com/568c0d8a-4038-4d96-931b-a2afb848f6c8.jpg" , EventMonth="S/.",
                                   EventName="Suspiro Limeño", EventDate="80", IsUpcoming=true,
                                   EventTime="1h 30 min" },
                 new EventList {  ImagePath = "https://t2.rg.ltmcdn.com/es/images/2/3/8/img_dulce_de_limon_con_galletas_23832_600.jpg" , EventMonth="S/.",
                                   EventName="Dulce de Limón", EventDate="60",IsPopular=true,
                                   EventTime="1h 15 min"},
                 new EventList { ImagePath =  "https://t1.rg.ltmcdn.com/es/images/0/7/4/panqueques_super_faciles_de_hacer_51470_600.jpg" , EventMonth="S/.",
                                   EventName="Panqueques Peruanos", EventDate="60", IsUpcoming=true,
                                   EventTime="40 min"},
                 new EventList { ImagePath = "https://www.perudelights.com/wp-content/uploads/2013/01/Picarones-1024x768.jpg", EventMonth="S/.",
                                   EventName="Picarones", EventDate="60",IsPopular=true,
                                   EventTime="1h 00 min"}
            };

            this.PopularEventItems = EventItems.Where(item => item.IsUpcoming == true).ToList();

            this.UpcomingEventItems = EventItems.Where(item => item.IsPopular == true).ToList();

        }
        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the event items collection.
        /// </summary>
        public List<EventList> EventItems
        {
            get
            {
                return this.eventItems;
            }

            set
            {
                this.eventItems = value;
                this.NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets the upcoming events collection.
        /// </summary>
        public List<EventList> UpcomingEventItems
        {
            get
            {
                return this.upcomingEventItems;
            }

            set
            {
                this.upcomingEventItems = value;
                this.NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets the popular events collection.
        /// </summary>
        public List<EventList> PopularEventItems
        {
            get
            {
                return this.popularEventItems;
            }

            set
            {
                this.popularEventItems = value;
                this.NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets the selected index of the event.
        /// </summary>
        public int SelectedIndex
        {
            get
            {
                return this.selectedIndex;
            }

            set
            {
                this.selectedIndex = value;
                SearchText = string.Empty;

            }
        }

        /// <summary>
        /// Gets or sets the search text in the event.
        /// </summary>
        public string SearchText
        {
            get
            {
                return this.searchText;
            }

            set
            {
                this.searchText = value;
                UpdateSelectedText();
                this.NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets the all list search text in the collection.
        /// </summary>
        public string AllListSearchText
        {
            get
            {
                return this.allListSearchText;
            }

            set
            {
                allListSearchText = value;
                this.NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets the upcoming list search text in the collection.
        /// </summary>
        public string UpcomingListSearchText
        {
            get
            {
                return this.upcomingListSearchText;
            }

            set
            {
                upcomingListSearchText = value;
                this.NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets the popular list search text collection.
        /// </summary>
        public string PopularListSearchText
        {
            get
            {
                return this.popularListSearchText;
            }

            set
            {
                popularListSearchText = value;
                this.NotifyPropertyChanged();
            }
        }

        #endregion

        #region Methods

        private void UpdateSelectedText()
        {
            switch (selectedIndex)
            {
                case 0:
                    AllListSearchText = searchText;
                    break;

                case 1:
                    UpcomingListSearchText = searchText;
                    break;

                case 2:
                    PopularListSearchText = searchText;
                    break;
            }
        }
        #endregion
    }
}
