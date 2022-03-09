using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Question : MonoBehaviour
{
    private string question;
    private string AnswerA;
    private string AnswerB;
    private string CorrectAnswer;
    private List<List<string>> NH, ZH, Z, NB, U, FL, FR, GR, D, GE, O, L;
    private List<List<List<string>>> provinces;
    private string province;
    void Start()
    {


        province = this.gameObject.tag;
    }



    private void InstantiateQuestions()
    {
        //NB
        string P1Q1 = "What is the biggest city of North-Brabant?"; //Province 1 question 1
        string P1Q1A1 = "‘s-Hertogenbosch ";                        //Province 1 Question 1 Answer 1
        string P1Q1A2 = "Tilburg";
        string P1Q1CA = "Eindhoven";                                //Province 1 Question 1 Correct Answer
        string P1Q1I = "Not only is it the biggest city of North-Brabant it is also fifth largest city in the Netherlands with around 231 thousand people living there. Eindhoven got their city rights in the year 1232. The first Philips Factory was in Eindhoven and it is now a museum.  ";
        //info for after question
        List<string> P1Q1C = new List<string> { P1Q1, P1Q1A1, P1Q1A2, P1Q1CA, P1Q1I }; //This is the best solution i could come up with for this.

        string P1Q2 = "Which city holds the biggest fair every year?";
        string P1Q2A1 = "Helmond";
        string P1Q2A2 = "Roosendaal";
        string P1Q2CA = "Tilburg";
        string P1Q2I = "The Tilburg fair is the biggest fair in the Benelux, it has around 250 attractions every year. The city closes the city centre to make room for this fair making it around 4.5 kilometres long! The fair is one of the most attended events in the Netherlands having more than a million people going every year. ";

        List<string> P1Q2C = new List<string> { P1Q2, P1Q2A1, P1Q2A2, P1Q2CA, P1Q2I };

        string P1Q3 = "Which city is the capital city of North-Brabant?";
        string P1Q3A1 = "Oss";
        string P1Q3A2 = "Bergen op zoom";
        string P1Q3CA = "‘s-Hertogenbosch";
        string P1Q3I = "The city of ’s-Hertogenbosch has the nickname ‘Moerasdraak’ Meaning swamp dragon. The nickname was giving to the city because of their role in the Eighty Years’ War (Dutch War of Independence) The was surrounded by a swamp making the city very difficult to infiltrate.";
        List<string> P1Q3C = new List<string> { P1Q3, P1Q3A1, P1Q3A2, P1Q3CA, P1Q3I };
        NB = new List<List<string>> { P1Q1C, P1Q2C, P1Q3C };

        //U
        string P2Q1 = "Utrecht is known for having the most beautiful ___";
        string P2Q1A1 = "Night life";
        string P2Q1A2 = "Nature preserves";
        string P2Q1CA = "Canals";
        string P2Q1I = "The most known canal in Utrecht is the ‘Oudegracht’ and it is about 2 kilometres long. People also describe the canals in Utrecht to be more romantic then those in Amsterdam seeing how the ones in Utrecht aren’t as structured and straight.  ";

        List<string> P2Q1C = new List<string> { P2Q1, P2Q1A1, P2Q1A2, P2Q1CA, P2Q1I };

        string P2Q2 = "What building is depicted on the manhole covers in Utrecht? ";
        string P2Q2A1 = "Centraal Museum";
        string P2Q2A2 = "Sonnenborgh Observatory";
        string P2Q2CA = "The Domtoren";
        string P2Q2I = "The Domtoren was built in 1254 and is 112,32 meters long making it the highest church in the Netherlands and the highest building in Utrecht.  ";
        List<string> P2Q2C = new List<string> { P2Q2, P2Q2A1, P2Q2A2, P2Q2CA, P2Q2I };

        string P2Q3 = "What are the names of the smallest and biggest bells in the Domtoren?";
        string P2Q3A1 = "Maria and Stella";
        string P2Q3A2 = "Cornelius and Nikolas";
        string P2Q3CA = "Adrianus and Salvator";
        string P2Q3I = "The Domtoren has 14 bells being rung daily by hand on Sundays, religious holidays and special occasions. The bell Salvator weighs about 8.200 kilo’s and Adrianus about 280 kilo’s. All of the bells combine weigh about 31.000 kilo’s. ";
        List<string> P2Q3C = new List<string> { P2Q3, P2Q3A1, P2Q3A2, P2Q3CA, P2Q3I };
        U = new List<List<string>> { P2Q1C, P2Q2C, P2Q3C };

        //ZH
        string P3Q1 = "When did the popular park known as ‘Keukenhof’ open? ";
        string P3Q1A1 = "1945";
        string P3Q1A2 = "1970";
        string P3Q1CA = "1950";
        string P3Q1I = "The Keukenhof has a castle that was built in 1641 around this time the estate grew to be about 200 hectare. The first year that the park was opened to the public it had about 236.000 visitors and it grows every year.  ";

        List<string> P3Q1C = new List<string> { P3Q1, P3Q1A1, P3Q1A2, P3Q1CA, P3Q1I };

        string P3Q2 = "The popular attraction known as ‘Kinderdijk’ Is a ____";
        string P3Q2A1 = "World wonder";
        string P3Q2A2 = "World record holder for most dikes";
        string P3Q2CA = "UNESCO world heritage site";
        string P3Q2I = "In kinderdijk there are about 19 windmills that drain the water from the polders into the river for centuries. The windmills became a part of the UNESCO World Heritage in 1970. ";
        List<string> P3Q2C = new List<string> { P3Q2, P3Q2A1, P3Q2A2, P3Q2CA, P3Q2I };

        string P3Q3 = "The open air museum known as ‘Archeon’ is all about? ";
        string P3Q3A1 = "The Dutch military ";
        string P3Q3A2 = "The Dutch battle against the ocean";
        string P3Q3CA = "How the Dutch lived in antiquity";
        string P3Q3I = "Archeon is an air and living museum, it opened in 1994 it features a range of different historical periods of the Netherlands. Watch historical re-enactments and learn about the Stone Age, Roman times and the Medieval Period.  ";
        List<string> P3Q3C = new List<string> { P3Q3, P3Q3A1, P3Q3A2, P3Q3CA, P3Q3I };
        ZH = new List<List<string>> { P3Q1C, P3Q2C, P3Q3C };

        //GE
        string P4Q1 = "How many hectare is the Veluwe?  ";
        string P4Q1A1 = "85.300";
        string P4Q1A2 = "73.590";
        string P4Q1CA = "91.200";
        string P4Q1I = "Being it size the Veluwe is one of the biggest national parks of Northwest-Europe. The Veluwe has been around for over 150.000 years, hosting many different animals like the red deer and wild boars. ";

        List<string> P4Q1C = new List<string> { P4Q1, P4Q1A1, P4Q1A2, P4Q1CA, P4Q1I };

        string P4Q2 = "What makes the Kröller-Müller museum so special? ";
        string P4Q2A1 = "It's a museum about cookies ";
        string P4Q2A2 = "It is a World War 2 museum";
        string P4Q2CA = "It has a Sculpture Garden";
        string P4Q2I = "The Kröller-Müller Museum was founded by Helene Kröller-Müller, she was one of the first major female art collectors in Europe. The Kröller-Müller museum has the second largest collection of Van Gogh paintings also homing one the sunflowers from Van Gogh’s still life series.  ";
        List<string> P4Q2C = new List<string> { P4Q2, P4Q2A1, P4Q2A2, P4Q2CA, P4Q2I };

        string P4Q3 = "Who currently resides in 'Het Loo Palace' ";
        string P4Q3A1 = "The king and Queen";
        string P4Q3A2 = "The prime minister";
        string P4Q3CA = "No one";
        string P4Q3I = "Located in Apeldoorn, built in between 1684 and 1686 for stadtholder-king William III and Mary II of England. The building has been in possession of the state since 1962. The last people living in the palace where Princess Margriet and her family they left in 1977 and the palace has been a museum since 1984.  ";
        List<string> P4Q3C = new List<string> { P4Q3, P4Q3A1, P4Q3A2, P4Q3CA, P4Q3I };
        GE = new List<List<string>> { P4Q1C, P4Q2C, P4Q3C };

        //D
        string P5Q1 = "How many Dolmens are there in Drenthe? ";
        string P5Q1A1 = "48";
        string P5Q1A2 = "62";
        string P5Q1CA = "52";
        string P5Q1I = "Dolmens are according to theories remnants of burial grounds from the prehistory. Dolmans in the Netherlands do not have names they can be identified with numbers. The boulders where caried by ice to Drenthe during the ice age. ";

        List<string> P5Q1C = new List<string> { P5Q1, P5Q1A1, P5Q1A2, P5Q1CA, P5Q1I };

        string P5Q2 = "How long is ‘The Drentsche Aa’ (A stream)";
        string P5Q2A1 = "29 kilometres";
        string P5Q2A2 = "26 kilometres";
        string P5Q2CA = "28 Kilometres";
        string P5Q2I = "The Drentsche Aa flows through the like named national park the appeal of this stream is that is hasn’t been straightened like other likewise streams in the Netherlands. Techinacly the stream isn’t actually called the Drentsche Aa but all the branches of it has their own name but the collective of it is called the Drentsche Aa. ";
        List<string> P5Q2C = new List<string> { P5Q2, P5Q2A1, P5Q2A2, P5Q2CA, P5Q2I };

        string P5Q3 = "What can you do in the Prison Museum ";
        string P5Q3A1 = "Get your friends arrested";
        string P5Q3A2 = "Speak to prisoners ";
        string P5Q3CA = "Spend the night";
        string P5Q3I = "Located in Apeldoorn, built in between 1684 and 1686 for stadtholder-king William III and Mary II of England. The building has been in possession of the state since 1962. The last people living in the palace where Princess Margriet and her family they left in 1977 and the palace has been a museum since 1984.  ";
        List<string> P5Q3C = new List<string> { P5Q3, P5Q3A1, P5Q3A2, P5Q3CA, P5Q3I };
        D = new List<List<string>> { P5Q1C, P5Q2C, P5Q3C };

        //L
        string P6Q1 = "What painting was kept safe during World War 2 in the St. Peter’s Caves in Limburg ";
        string P6Q1A1 = "Sunflowers, Vincent van Gogh";
        string P6Q1A2 = "Girl with a Pearl Earring, Johannes Vermeer ";
        string P6Q1CA = "Night Watch, Rembrandt van Rijn";
        string P6Q1I = "The St. Peter’s Caves are located in Maastricht the origin dates back to the 13th Centtury. The caves are a collection of limestone quarries. The Caves were a collection of 20.000 tunnels and about 8.000 of these tunnels are still intact.";

        List<string> P6Q1C = new List<string> { P6Q1, P6Q1A1, P6Q1A2, P6Q1CA, P6Q1I };

        string P6Q2 = "How many countries adjoin near the top of the Vaalserberg? ";
        string P6Q2A1 = "2";
        string P6Q2A2 = "4";
        string P6Q2CA = "3";
        string P6Q2I = "The Vaalserberg (The last part of the name ‘Berg’ Translates to mountain) is not actually a mountain but a hill. The vaalserberg is 322 meters high  and the highest natural point of the Netherlands. But not the kingdom of the Netherlands that title is for Mount Scenery with a height of 887 meters.  ";
        List<string> P6Q2C = new List<string> { P6Q2, P6Q2A1, P6Q2A2, P6Q2CA, P6Q2I };

        string P6Q3 = "In what century was the Saint Servatius Basilica build? ";
        string P6Q3A1 = "6th";
        string P6Q3A2 = "2nd";
        string P6Q3CA = "11th";
        string P6Q3I = "The Basilica was theorised to be the fourth building to be built on the grounds that it now stands on. The first being estimated to be built in the fourth century. The building is dedicated to saint Servatius as the name implies but people also believe the Basilica is built on top of his burial place.  ";
        List<string> P6Q3C = new List<string> { P6Q3, P6Q3A1, P6Q3A2, P6Q3CA, P6Q3I };
        L = new List<List<string>> { P6Q1C, P6Q2C, P6Q3C };

        //O
        string P7Q1 = "What is Giethoorn known for?  ";
        string P7Q1A1 = "Roads and Shops ";
        string P7Q1A2 = "Houses and Parks";
        string P7Q1CA = "Waterways and bridges";
        string P7Q1I = "Giethoorn counts 2630 residents. Giethoorn has around 176 bridges but most of these bridges are private property. You could say that many of the houses in Giethoorn are built on islands.  ";

        List<string> P7Q1C = new List<string> { P7Q1, P7Q1A1, P7Q1A2, P7Q1CA, P7Q1I };

        string P7Q2 = "What is the most well-known art museum in Zwolle called? ";
        string P7Q2A1 = "Museum de Krantoni";
        string P7Q2A2 = "Museum de Pavaroti";
        string P7Q2CA = "Museum de Fundatie";
        string P7Q2I = "Zwolle still has some remnants of it’s city wall standing, these wall were built against sieges and cannon fire. The city wall used to encase the whole city and it had 23 towers only three of these tower remain to this day. ";
        List<string> P7Q2C = new List<string> { P7Q2, P7Q2A1, P7Q2A2, P7Q2CA, P7Q2I };

        string P7Q3 = "What is the most beautiful rivier in Deventer?  ";
        string P7Q3A1 = "Ijshoorn river";
        string P7Q3A2 = "Hoogput river";
        string P7Q3CA = "Ijsel river";
        string P7Q3I = "The city of deventer is known for its biscuit (Deventer koek) that is how it got the nickname biscuitcity (Koekstad). In the 16th century It was so important that if you wanted to make this biscuit it had to follow city standard and they had their own biscuit guild. In the 16th century the guild had 13 bakers and in the 17th century 25. ";
        List<string> P7Q3C = new List<string> { P7Q3, P7Q3A1, P7Q3A2, P7Q3CA, P7Q3I };
        O = new List<List<string>> { P7Q1C, P7Q2C, P7Q3C };

        //NH
        string P8Q1 = "Where is the cheese market? ";
        string P8Q1A1 = "Volendam";
        string P8Q1A2 = "Ijmuiden";
        string P8Q1CA = "Alkmaar";
        string P8Q1I = "Every Friday of the months April till September you can visit the cheese market in Alkmaar. The market starts at ten A.M. And you get to watch how the cheese gets sold like how they have been doing it for centuries long. They cheese market has been around since 1365 when they only had one cheese scale at the market.  ";

        List<string> P8Q1C = new List<string> { P8Q1, P8Q1A1, P8Q1A2, P8Q1CA, P8Q1I };

        string P8Q2 = "Who died around Muiderslot? ";
        string P8Q2A1 = "Alexander XVI";
        string P8Q2A2 = "Willem van Oranje";
        string P8Q2CA = "Floris de V";
        string P8Q2I = "Castle Muiderslot was built around 1280 and in it’s life time it has been lived in, sieged, demolished, rebuilt and renovated. Since 1878 it has been a national museum making it one of the first in the Netherlands. Muiderslot is located in Muiden an old historic town with many great historic sightings.   ";
        List<string> P8Q2C = new List<string> { P8Q2, P8Q2A1, P8Q2A2, P8Q2CA, P8Q2I };

        string P8Q3 = "Which church is the oldest in Noord-Holland? ";
        string P8Q3A1 = "Oude kerk";
        string P8Q3A2 = "Sint-Servaasbasiliek";
        string P8Q3CA = "Engelmunduskerk";
        string P8Q3I = "The Engelmunduskerk is the town church of Velsen-Zuid built in the 10th or 11th century. It was named after Engelmundus, according to tradition he was born in England to a Frisian family";
        List<string> P8Q3C = new List<string> { P8Q3, P8Q3A1, P8Q3A2, P8Q3CA, P8Q3I };
        NH = new List<List<string>> { P8Q1C, P8Q2C, P8Q3C };

        //GR
        string P9Q1 = "What was the first bridge in Groningen(City)? ";
        string P9Q1A1 = "Berlagebrug";
        string P9Q1A2 = "Museumbrug";
        string P9Q1CA = "Abrug";
        string P9Q1I = "The Abrug is a swing bridge located in the city of Groningen although that was ofcourse not the first bridge in Groningen, but the old Abrug was located in the same place the current one lays. The first Abrug was made out of wood and was made in 1192 according to records. ";

        List<string> P9Q1C = new List<string> { P9Q1, P9Q1A1, P9Q1A2, P9Q1CA, P9Q1I };

        string P9Q2 = "How tall is the Martinitoren  ";
        string P9Q2A1 = "101,5 Meters";
        string P9Q2A2 = "93.4 Meters";
        string P9Q2CA = "96,8 Meters";
        string P9Q2I = "Located in the city of Gronigen at ‘de Grote Markt’ (Big market) the Martinitoren they begin building this tower in 1469 according to records and stories the build of the tower took 79-85 years to build. The tower was supposed to be over 100 meters long but because of fire, lightning and war the tower was broken and restored quite a view times.   ";
        List<string> P9Q2C = new List<string> { P9Q2, P9Q2A1, P9Q2A2, P9Q2CA, P9Q2I };

        string P9Q3 = "Where is the Seal care centre located in Groningen? ";
        string P9Q3A1 = "Groningen ";
        string P9Q3A2 = "Veendam";
        string P9Q3CA = "Pieterburen";
        string P9Q3I = "The seal care centre is an animal hospital for seals. The hospital takes care of seal who get sick, injured or have a difficult time at sea for whatever reason and tries to help them. The centre was established in 1971 and have been saving seals ever since. In 1981 they even had a sealion for one night before releasing on the German island Helgoland.  ";
        List<string> P9Q3C = new List<string> { P9Q3, P9Q3A1, P9Q3A2, P9Q3CA, P9Q3I };
        GR = new List<List<string>> { P9Q1C, P9Q2C, P9Q3C };

        //FR
        string P10Q1 = "The national flag of Friesland is known for their ‘Pompeblêden’ ";
        string P10Q1A1 = "Hearts";
        string P10Q1A2 = "Kidney beans";
        string P10Q1CA = "Lily pads";
        string P10Q1I = "The flag has seven Pompeblêden this has a meaning in the mythology of how the people in Friesland came in existence. The Myth follows as such, the ancestor had seven sons who all sailed out to their own region and that is where the ‘Friezen’ lived.  ";

        List<string> P10Q1C = new List<string> { P10Q1, P10Q1A1, P10Q1A2, P10Q1CA, P10Q1I };

        string P10Q2 = "When was the last ‘elfstedentocht’ ";
        string P10Q2A1 = "1987";
        string P10Q2A2 = "1999";
        string P10Q2CA = "1997";
        string P10Q2I = "The ‘Elfstedentocht’ is a 200 kilometre long ice skating tour on natural ice. The people had to skate on natural ice, trough eleven cities starting and ending in Leeuwarden. The first official one took place in 1909. During then and now the tour has taken place a total of 15 times.";
        List<string> P10Q2C = new List<string> { P10Q2, P10Q2A1, P10Q2A2, P10Q2CA, P10Q2I };

        string P10Q3 = "What kind of bread is traditional to give in Friesland? ";
        string P10Q3A1 = "Rye bread";
        string P10Q3A2 = "Stick bread";
        string P10Q3CA = "Sugar bread";
        string P10Q3I = "The tradition was to give mothers who just gave birth to a daughter sugar bread to make the mother stronger after giving birth. It was believed that the ingredients would make the mother strong and make her a capable mother.  ";
        List<string> P10Q3C = new List<string> { P10Q3, P10Q3A1, P10Q3A2, P10Q3CA, P10Q3I };
        FR = new List<List<string>> { P10Q1C, P10Q2C, P10Q3C };

        //Z
        string P11Q1 = "Wat is the contruction called that keeps the water out of zeeland? ";
        string P11Q1A1 = "Waterlocks";
        string P11Q1A2 = "Watercork";
        string P11Q1CA = "Deltawerken";
        string P11Q1I = "Deltawerken (Deltaworks) is an important defence system in the Netherlands it is in place to protect the Netherlands against the high sea levels. The project took decades to complete. The plan was first revealed in 1942 but the flood of ’53 put the project in high gear.";

        List<string> P11Q1C = new List<string> { P11Q1, P11Q1A1, P11Q1A2, P11Q1CA, P11Q1I };

        string P11Q2 = "In what year did the ‘Watersnoodramp’ (Big Flood) in Zeeland happen? ";
        string P11Q2A1 = "1960";
        string P11Q2A2 = "1947";
        string P11Q2CA = "1953 ";
        string P11Q2I = "The flood of 1953 was the biggest natural disaster for the Netherland to occur in the 20th Century, the spring tide flooded a large parts of the country. It left many people without their homes and it even claimed over a thousand lives.";
        List<string> P11Q2C = new List<string> { P11Q2, P11Q2A1, P11Q2A2, P11Q2CA, P11Q2I };

        string P11Q3 = "In Vlissingen lays an old Seafort. What is it called? ";
        string P11Q3A1 = "Fort Muiderslot";
        string P11Q3A2 = "Fort Kijkduin";
        string P11Q3CA = "Fort Rammekens";
        string P11Q3I = "The fort dates back to 1547, it was build to control and protect the shipping lanes toward Middelburg. During this time Middelburg was the largest buying city of the Netherlands. The fort was a tactical point in the 80th year war and was sieged by multiple people.   ";
        List<string> P11Q3C = new List<string> { P11Q3, P11Q3A1, P11Q3A2, P11Q3CA, P11Q3I };
        Z = new List<List<string>> { P11Q1C, P11Q2C, P11Q3C };

        //FL
        string P12Q1 = "Before Flevoland got created, the area was a giant sea. Which sea? ";
        string P12Q1A1 = "Waddenzee";
        string P12Q1A2 = "Nederzee ";
        string P12Q1CA = "Zuiderzee";
        string P12Q1I = "Flevoland is the youngest of the provinces in the Netherlands seeing how it isn’t a natural piece of land but one we made ourselves. The Netherlands drained a part of the ‘Zuiderzee’ to create Flevoland. It took around 75 years to create Flevoland.  ";

        List<string> P12Q1C = new List<string> { P12Q1, P12Q1A1, P12Q1A2, P12Q1CA, P12Q1I };

        string P12Q2 = "What is the dyke going from Enkuizen to Lelystad called? ";
        string P12Q2A1 = "Afsluitdijk";
        string P12Q2A2 = "Zeedijk";
        string P12Q2CA = "Houtribdijk";
        string P12Q2I = "The Houtribijk is the second longest dyke in the Netherlands next to the ‘afsluitdijk’. The dyke separates the ‘Ijselmeer and the ‘Markermeer’.  The dyke was built between 1963 and 1976. The dyke is 26 kilometres long, and it was supposed to be used to impolder a part of the ‘Ijselmeer’ but in 2003 it was decided that the plan would not go into action.  ";
        List<string> P12Q2C = new List<string> { P12Q2, P12Q2A1, P12Q2A2, P12Q2CA, P12Q2I };

        string P12Q3 = "What big open mall in Lelystad is named after a VOC ship? ";
        string P12Q3A1 = "Akerslootstad";
        string P12Q3A2 = "AgathaStad";
        string P12Q3CA = "Bataviastad";
        string P12Q3I = "Bataviastad is a big Fashian Outlet located in Lelystad. The mall has been open since July 2001 and it is open everyday of the year. The Batavia ship is located next to the mall and can be viewed at the Batavia Werf. ";
        List<string> P12Q3C = new List<string> { P12Q3, P12Q3A1, P12Q3A2, P12Q3CA, P12Q3I };
        FL = new List<List<string>> { P12Q1C, P12Q2C, P12Q3C };

        provinces = new List<List<List<string>>> { NH, ZH, Z, NB, U, FL, FR, GR, D, GE, O, L }; //yes i despise this as much as you do
    }





    // Update is called once per frame
    void Update()
    {
        
    }
}
