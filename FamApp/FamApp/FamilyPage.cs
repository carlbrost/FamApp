using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using System.Threading.Tasks;

namespace FamApp //part 2
{
    class FamilyPage : ContentPage
    {
        public FamilyPage()
        {
            Title = "Family Page";

            StackLayout stacklayout = new StackLayout
            {

                VerticalOptions = LayoutOptions.CenterAndExpand,

                Children =
                {

                    new Label
                    { Text = "Amy Anderson"+Environment.NewLine, FontAttributes = FontAttributes.Bold, TextColor = Color.Pink, FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)), BackgroundColor = Color.Black, },
                    new Label { Text = "Amy Anderson is my mom, and a native of Aberdeen, South Dakota"+
                    "She's a practically a disney princess, honestly, in how kind and caring she is."+
                    "She's kept the family alive, and in one peice, mostly, more than few times with her medical knowledge. "+
                    "She's also one of the most gore resitant people alive. She's seen injuries on an hourly basis that would make most promptly hurl Or pass out."
                    },
                     new Label
                    { Text = "John Brost"+Environment.NewLine, FontAttributes = FontAttributes.Bold, TextColor = Color.Red, FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)), BackgroundColor = Color.Black, },

                    new Label { Text = "John Brost, is my dad and a native of Murdo, South Dakota"+
                    "He's a hardworking man, and is responsible for my family, halphazard as it's creation was, for being prosperous"+
                    "He's a bit of a renneisance man sometimes as well, being a history buff, an english major, a guitar player, a fisherman, and an excellent cook"+
                    "He's a big softie too. He just recently bought a new puppy, that he's damn eager to meet."
                    },
                    new Label
                    { Text = "Sigrid Brost"+Environment.NewLine, FontAttributes = FontAttributes.Bold, TextColor = Color.Aqua, FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)), BackgroundColor = Color.Black, },

                    new Label { Text = "Sigrid brost is my younger sister by 4 years, though sometimes she feels like the older. "+
                    "She's a near straight A student, and works consistently, very hard, though she has some occasional moments that make it very obvious she's an Edina girl"+
                    "She's working to learn the ukele at the moment, though progress has been rather slow"+
                    "She's a former gymnast, and can still do a stunning amount of cartwheels. "
                    },
                    new Label
                    { Text = "Wallace D."+Environment.NewLine, FontAttributes = FontAttributes.Bold, TextColor = Color.Silver, FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)), BackgroundColor = Color.Black, },

                    new Label { Text = "A 20 year old westie, and a bit of a chubby sausage, in his old age"+
                    "He's pretty much attached to my mom at the hip, and rarely leaves her side."+
                    "That said he's had a number of highly impressive escape attempts, one of whcih, in his prime, ended up with him all the way in across highway 484. Somehow"+
                    "He's also eaten 10 bars of chocolate at once. I marvel at how he's still alive, honestly. "
                    },
                    new Label
                    { Text = "Princess Leia Lulu"+Environment.NewLine, FontAttributes = FontAttributes.Bold, TextColor = Color.Maroon, FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)), BackgroundColor = Color.Black, },

                    new Label { Text = "Lulu is our cat, a burmeese little thing, about 10 years old, and a curious litttle thing. "+
                    "Her first year was rough, as she was constantly sick. When we called the breeder about her problems, we found that she'd vanished. "+
                    "But much like her namesake, she's deceptively tough, and survived her disease, as well as a few nights out in the cold before yeowling outside a window to let her back in"+
                    "She's prettymuch infamous at this point for her dislike of humans other than our family, though strangely, she rather seems to come out if there's italian food. Pizza in particular "
                    },
                                         new Label
                    { Text = "Carl Brost"+Environment.NewLine, FontAttributes = FontAttributes.Bold, TextColor = Color.Purple, FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)), BackgroundColor = Color.Black, },

                    new Label { Text = "That's myself, 24 year old nerd, lover of games of all kinds, and programmer"+
                    "I'm a bit of a space case, but I'm working to dedicate myself to my dreams, as well as stay alive"+
                    "I also love tabletop roleplaying games, and run a campaign for me and a few friends online"+
                    "My biggest dream is to make a story, a high fantasy adventure that will inspire and bring people solace and joy."
                    },
    

                }
            };

            /* ADDING A STACKLAYOUT TO A STACKLAYOUT DOESNT WORK 
            StackLayout personal = new StackLayout {
              BackgroundColor = Color.Navy,
              VerticalOptions = LayoutOptions.FillAndExpand,
                Children = {
                    new Label
                    {
                        Text = "Carl's Stat sheet", FontAttributes = FontAttributes.Bold |FontAttributes.Italic, TextColor = Color.Maroon, 
                    },
                    new Label
                    {Text = "Race: Norther Hobbit"+Environment.NewLine+"Class:Ooze Alchemist" }



                }


            }; */

            //scrollview addition. 
            Content = new ScrollView
            { Orientation = ScrollOrientation.Vertical,
            Content = stacklayout

            };

        }

    }

  
}
