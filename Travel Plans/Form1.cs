using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Travel_Plans
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            String[] flights = { "December 2-5 (3 days) - $350", "December 2-7 (5 days) - $450", "December 23-30 (7 days) - $550" };
            String[] hotels = { "Island Beachcomber Hotel - $150", "Hotel Caravelle - $250", "Ritz-Carlton, St. Thomas - $350" };
            foreach (string flight in flights)
            {
                cbo_flights.Items.Add(flight);
            }
            foreach (string hotel in hotels)
            {
                cbo_hotels.Items.Add(hotel);

            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (cbo_flights.SelectedIndex == -1 || cbo_hotels.SelectedIndex == -1)
            {
                MessageBox.Show("A itinerary must be selected", "Entry Error");
                return;
            }
            else
            {
                CreditCard f5 = new CreditCard(); //Opening the customer info form              
                f5.ShowDialog();
            }
            MessageBox.Show(cbo_flights.Text + "\n" + cbo_hotels.Text + "\n\n" + txt_order.Text, "Trip Summary");
        }
        private void activities_CheckedChanged(object sender, EventArgs e)
        {

            int maxActivities = cbo_flights.SelectedIndex + 2;

            int numberChecked = 0;
            foreach (var control in grp_activities.Controls)
            {
                if (control.GetType() == typeof(CheckBox))
                {
                    var myCheckbox = (CheckBox)control;
                    if (myCheckbox.Checked)
                    {
                        numberChecked += 1;
                    }
                }
            }

            if (numberChecked > maxActivities)
            {
                var box = sender as CheckBox;
                box.Checked = false;
                MessageBox.Show("Maximum activites reached!", "Max Reached");
            }
            txt_order.Text = " ";
            txt_subtotal.Text = " ";
            txt_tax.Text = " ";
            txt_total.Text = " ";

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_subtotal.Text = " ";
            txt_tax.Text = " ";
            txt_total.Text = " ";
            cbo_flights.SelectedIndex = -1;
            cbo_hotels.SelectedIndex = -1;
            foreach (Control control in grp_activities.Controls)
            {
                if (control.GetType() == typeof(CheckBox))
                {
                    ((CheckBox)control).Checked = false;
                }
            }
        }

        private void btnorder_Click(object sender, EventArgs e)
        {
            if (cbo_flights.SelectedIndex == -1 || cbo_hotels.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an itinerary.", "Entry Error");
            }
            else
            {
                String[] flightsDes = { "3 Day trip to the US Virgin Islands", "5 Day trip to the US Virgin Islands", "7 day trip to the US Virgin Islands" };
                string flightDescription = flightsDes[cbo_flights.SelectedIndex];
                string[] hotelDes = {"Stay at the Island Beachcomber Hotel. Enjoy our sunshine, kick off your shoes, wiggle your toes in our warm sand and stay with us for awhile. The Island Beachcomber Hotel is located on Lindbergh Beach, recently voted one of the three best beaches on St Thomas*and just minutes from the town of Charlotte Amalie and the St Thomas Airport.",
                "Stay at the Hotel Caravelle. The Hotel Caravelle property, host to more than a half-million visitors to date, is a charming complex of gift, souvenir and clothing shops, offices, and several restaurants.",
                "Stay at the Rits-Carlton. As you gaze out at the blue horizon, dotted the gentle green hills of the neighboring islands, the soft sounds of steel pan drums tickle your ear. Reflexively, you relax and exhale, knowing you have landed in one unmistakably perfect destination, The Ritz-Carlton, St. Thomas, a luxury hotel able to seamlessly blend the unique culture of the Caribbean with penultimate luxury and refinement."};
                string hotelDescription = hotelDes[cbo_hotels.SelectedIndex];

                rtxtFlights.Text = flightDescription;
                rtxtHotels.Text = hotelDescription;

                decimal actPrice = 0;

                if (chkscuba.Checked)
                {
                    actPrice = 169;
                    txt_order.Text = "SCUBA DIVING $169\nNavy Barges - The twin barges originally housed men’s quarters during WWII. After the war, they were demolished and sunk,creating the ideal habitat for marine life. Trumpetfish, big angelfish, feather dusters and Christmas tree worms hang topside, while squirrelfish, bigeyes and channel clinging crabs hide out in the crawl spaces.\n\nOR\n\nCow & Calf - Located off the southeast coast of St.Thomas, the two largest rocks that break the surface are said to look like whales—a cow and her calf.Cow & Calf boasts dramatic ledges, wide canyons and large caves.";
                }
                else if(chksnork.Checked)
                {
                    actPrice = 99;
                    txt_order.Text = "SNORKING $99\nHurricane Hole (St. John): You may not immediately think of a mangrove forest as a great place to snorkel, but here coral grows in abundance on the mangrove roots—attended by huge starfish, sponges (and the hawksbills that eat them), and anemones. It’s magical. SerenaSea runs snorkeling and sightseeing tours out of Coral Bay to Hurricane Hole.\n\nOR\n\nNorman Island & the Indians (B.V.I.): Snorkel the calm waters of the Bight near Norman Island. Bring some bread to draw reef fish to the surface when you snorkel the deep waters around the Indians—four fingers of rock jutting out of the sea and only accessible by boat.";
                }
                else if (chkhorse.Checked)
                {
                    actPrice = 149;
                    txt_order.Text = "HORSEBACK RIDING $149\nHorseback riding can provide countless hours of fun and entertainment, but maintaining horses can be a costly undertaking. You may not have the time or resources to keep horses full time, but that doesn’t mean horseback riding is not possible. Most of these locations are under an hour’s drive away from the Twin Cities, making it very convenient to tackle a riding experience. With these stables, you and your family can learn to horseback ride without the high costs of keeping a horse. For those who already know how to ride, many of the stables listed below provide guided trail rides.";
                }
                else if (chkhike.Checked)
                {
                    actPrice = 199;
                    txt_order.Text = "HIKING $199\nSt.Croix is blessed with many different types of terrain -the lushness of the west end and the rainforest, the arid climate and cactus on the east end, the high peaks and gentle plains that line the mid - island coastlines.Going for a hike on St.Croix is one of the best ways to experience the truly beautiful views, often unseen from the main roadways.While many of the best hikes on St.Croix are accessible to the public, they are not necessarily well-marked with signs.";
                }
                else if (chkseafish.Checked)
                {
                    actPrice = 399;
                    txt_order.Text = "SEAFISIHING $399\nVarious world records in fishing have been set in the Virgin Islands including the still-standing IGFA Women’s ‘All-Tackle’ world record for blue marlin; a 1073 pounder reeled in by Annette Maudi Dallimor on July 6, 1982. These historic catches, some 21 records over the years, are a testament to the great fishing opportunities that exist in the Virgin Islands for anglers of all ages and experience levels.";
                }
                else if (chkholiday.Checked)
                {
                    actPrice = 50;
                    txt_order.Text = "HOLIDAY CARNIVAL $50\nSt.Croix hosts its Carnival Festival between Christmas and New Year.The Crucian Christmas Carnival sees events in both Christiansted and Frederiksted including calypso shows, Latin music venues, food fairs, horse races, parades and the village.";
                }
                else if (chkmarathon.Checked)
                {
                    actPrice = 49;
                    txt_order.Text = "HALF MARATHON $49\nThis is long distance running with the best scenic background. The race travels the east end loop of St. Croix from north to south, and is certified by the International Association of Athletic Federations and the Association of International Marathons and Distance Races. Finishing participants are awarded Pace Runners Virgin Islands Half-Marathon medals.";
                }
                else if (chkcoral.Checked)
                {
                    actPrice = 79;
                    txt_order.Text = "4th Annual Coral Bay Bizarre Bazaar Event $79\nLocation: Pickles\nLocal Artists *Local Products* Local Food & Beverage * Local Craft Beer Experience* Plant Sale* Raffle  *Activities & Santa";
                }
                else if (chkmahi.Checked)
                {
                    actPrice = 89;
                    txt_order.Text = "MAHI'S SEASIDE SEAFOOD $89\nSeafood prepared in the Caribbean style is what diner have to look forward to when they eat here. Mahi's Seaside Seafood Bar and Grill is a bar and grill where they proudly serve their take on Caribbean cuisine. One can expect the setting and food here to be informal. Diners are welcome to come by to enjoy both dinner and lunch, so give it a try.";
                }
                else if (chkcoconuts.Checked)
                {
                    actPrice = 99;
                    txt_order.Text = "COCONUT COLLECTION $99\nCoconuts on the Beach, located on St.Croix’s tranquil west end is THE place to relax and unwind after a hard day’s work or a hard day of vacation. Our menu is a little bit Caribbean, a little bit Tex-Mex, a little bit American – definitely something for everyone.Enjoy a cold beverage, the Caribbean.";
                }


                decimal[] flightPrice = { 350, 450, 550 };// parallel array for price
                decimal fPRICE = flightPrice[cbo_flights.SelectedIndex];

                decimal[] hotelPrice = { 150, 250, 350 }; //parallel array for price
                decimal hPRICE = hotelPrice[cbo_hotels.SelectedIndex];

                decimal sTOTAL = fPRICE + hPRICE + actPrice;//calculates the subtotal, tax and total
                decimal TAX = (fPRICE + hPRICE) * .07m;
                decimal TOTAL = sTOTAL + TAX;

                string sub = String.Format("{0:c}", sTOTAL);//converts total, tax and subtotal and formats for output
                txt_subtotal.Text = Convert.ToString(sub);
                string tax = String.Format("{0:c}", TAX);
                txt_tax.Text = Convert.ToString(tax);
                string total = String.Format("{0:c}", TOTAL);
                txt_total.Text = Convert.ToString(total);
            }
        }

        private void cbo_flights_SelectedIndexChanged(object sender, EventArgs e)
        {
            rtxtFlights.Text = "";
            rtxtHotels.Text = "";
            foreach (Control control in grp_activities.Controls)
            {
                if (control.GetType() == typeof(CheckBox))
                {
                    ((CheckBox)control).Checked = false;
                }
            }
        }
    }
}



