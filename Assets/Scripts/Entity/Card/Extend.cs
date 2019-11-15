using System.Collections.Generic;
using UnityEngine;

namespace Entity.Card
{
    namespace Extend
    {
        public class Card
        {
            public readonly long Id;
            public readonly string Name;
            public readonly string Img;
            public readonly string Type;
            public readonly long[] Skills;
            public readonly long Hp;
            public readonly long Mp;
            public readonly long Def;
            public readonly long Mag;
            public readonly long Atk;
            public readonly long Ene;
            public readonly long HpGrow;
            public readonly long MpGrow;
            public readonly long AtkGrow;
            public readonly long EneGrow;

            public Card(long id, string name, string img, string type, long[] skills)
            {
                Id = id;
                Name = name;
                Img = img;
                Type = type;
                Skills = skills;
            }

            public Card(long id, string name, string img, string type, 
                        long[] skills, long hp, long mp, long def,
                        long mag, long atk, long ene, long hpGrow, 
                        long mpGrow, long atkGrow, long eneGrow)
            {
                Id = id;
                Name = name;
                Img = img;
                Type = type;
                Skills = skills;
                Hp = hp;
                Mp = mp;
                Def = def;
                Mag = mag;
                Atk = atk;
                Ene = ene;
                HpGrow = hpGrow;
                MpGrow = mpGrow;
                AtkGrow = atkGrow;
                EneGrow = eneGrow;
            }

            public Card(CardArray card)
            {
                Id = card.Id;
                Name = card.Name;
                Img = card.Img;
                Type = card.Type;
                Skills = card.Skills;
                Hp = card.Hp;
                Mp = card.Mp;
                Def = card.Def;
                Mag = card.Mag;
                Atk = card.Atk;
                Ene = card.Ene;
                HpGrow = card.HpGrow;
                MpGrow = card.MpGrow;
                AtkGrow = card.AtkGrow;
                EneGrow = card.EneGrow;
            }
            
        }

        public class Cards
        {
            public readonly string Date;
            public readonly string Author;
//            public Dictionary<string, Card> CardArray => _cardArray;

            private Dictionary<string, Card> _cardArray;

            public Cards(global::Entity.Card.Cards cards)
            {
                _cardArray = new Dictionary<string, Card>();

                Date = cards.Date;
                Author = cards.Author;

                foreach (var card in cards.CardArray)
                {
                    _cardArray.Add(card.Name, 
                        new Card(card));
                }
            }

            //如果没有对应的值，则返回key
            public string GetImg(string key)
            {
                if (_cardArray.ContainsKey(key))
                {
                    return _cardArray[key].Img;
                }
                else
                {
                    return key;
                }
            }

            public Card At(string key)
            {
                if (_cardArray.ContainsKey(key))
                {
                    return _cardArray[key];
                }
                else
                {
                    return null;
                }
            }

            public static Cards CreateCard()
            {
                var cards = global::Entity.Card.Cards.FromJson(Resources.Load<TextAsset>("Json/Cards").text);
                var res =  new Cards(cards);
                return res;
            }
        }
    }
    
}