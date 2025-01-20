/* I added a list of scriptures that can be randomly 
picked for the user to memorise. And I made sure to do the stretch challenge where
the hiding of the words only happen to the ones not hidden already.
I also added that once one scripture is fully hidden, the program
does not end when the user presses enter again, reather it gets a new scripture
at random and they play again until they type in 'exit' to end the program.
I also made it so that the user presses enter to begin so the scripture shows to show it has
begun, or they type exit to end it.
*/

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    // List of scriptures and their references
    private static List<Scripture> GetScriptureList()
    {
        return new List<Scripture>
        {
            new Scripture(
                new ScriptureReference("Proverbs", 3, 5, 6),
                "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths."
            ),
            new Scripture(
                new ScriptureReference("John", 3, 16),
                "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."
            ),
            new Scripture(
                new ScriptureReference("Psalm", 23, 1, 2),
                "The Lord is my shepherd; I shall not want. He maketh me to lie down in green pastures: he leadeth me beside the still waters."
            ),
            new Scripture(
                new ScriptureReference("Isaiah", 41, 10),
                "Fear thou not; for I am with thee: be not dismayed; for I am thy God: I will strengthen thee; yea, I will help thee; yea, I will uphold thee with the right hand of my righteousness."
            ),
            new Scripture(
                new ScriptureReference("Romans", 8, 28),
                "And we know that all things work together for good to them that love God, to them who are the called according to his purpose."
            ),
            new Scripture(
                new ScriptureReference("Philippians", 4, 13),
                "I can do all things through Christ which strengtheneth me."
            ),
            new Scripture(
                new ScriptureReference("Matthew", 6, 33),
                "But seek ye first the kingdom of God, and his righteousness; and all these things shall be added unto you."
            ),
            new Scripture(
                new ScriptureReference("Jeremiah", 29, 11),
                "For I know the thoughts that I think toward you, saith the Lord, thoughts of peace, and not of evil, to give you an expected end."
            ),
            new Scripture(
                new ScriptureReference("Psalm", 46, 1),
                "God is our refuge and strength, a very present help in trouble."
            ),
            new Scripture(
                new ScriptureReference("2 Corinthians", 5, 7),
                "For we walk by faith, not by sight."
            ),
            new Scripture(
                new ScriptureReference("1 Peter", 5, 7),
                "Casting all your care upon him; for he careth for you."
            ),
            new Scripture(
                new ScriptureReference("James", 1, 5),
                "If any of you lack wisdom, let him ask of God, that giveth to all men liberally, and upbraideth not; and it shall be given him."
            ),
            new Scripture(
                new ScriptureReference("Romans", 12, 2),
                "And be not conformed to this world: but be ye transformed by the renewing of your mind, that ye may prove what is that good, and acceptable, and perfect, will of God."
            ),
            new Scripture(
                new ScriptureReference("Hebrews", 11, 1),
                "Now faith is the substance of things hoped for, the evidence of things not seen."
            ),
            new Scripture(
                new ScriptureReference("Colossians", 3, 23),
                "And whatsoever ye do, do it heartily, as to the Lord, and not unto men;"
            ),
            new Scripture(
                new ScriptureReference("Matthew", 7, 7),
                "Ask, and it shall be given you; seek, and ye shall find; knock, and it shall be opened unto you."
            ),
            new Scripture(
                new ScriptureReference("Psalm", 119, 105),
                "Thy word is a lamp unto my feet, and a light unto my path."
            ),
            new Scripture(
                new ScriptureReference("1 Corinthians", 10, 13),
                "There hath no temptation taken you but such as is common to man: but God is faithful, who will not suffer you to be tempted above that ye are able; but will with the temptation also make a way to escape, that ye may be able to bear it."
            ),
            new Scripture(
                new ScriptureReference("Luke", 6, 38),
                "Give, and it shall be given unto you; good measure, pressed down, and shaken together, and running over, shall men give into your bosom. For with the same measure that ye mete withal it shall be measured to you again."
            ),
            new Scripture(
                new ScriptureReference("Ephesians", 6, 10),
                "Finally, my brethren, be strong in the Lord, and in the power of his might."
            ),
            new Scripture(
                new ScriptureReference("1 John", 4, 19),
                "We love him, because he first loved us."
            ),
            new Scripture(
                new ScriptureReference("Galatians", 5, 22),
                "But the fruit of the Spirit is love, joy, peace, longsuffering, gentleness, goodness, faith, meekness, temperance: against such there is no law."
            ),
            new Scripture(
                new ScriptureReference("Proverbs", 4, 23),
                "Keep thy heart with all diligence; for out of it are the issues of life."
            ),
            new Scripture(
                new ScriptureReference("Psalm", 37, 4),
                "Delight thyself also in the Lord; and he shall give thee the desires of thine heart."
            ),
            new Scripture(
                new ScriptureReference("Isaiah", 40, 31),
                "But they that wait upon the Lord shall renew their strength; they shall mount up with wings as eagles; they shall run, and not be weary; and they shall walk, and not faint."
            ),
            new Scripture(
                new ScriptureReference("2 Timothy", 1, 7),
                "For God hath not given us the spirit of fear; but of power, and of love, and of a sound mind."
            ),
            new Scripture(
                new ScriptureReference("Romans", 10, 9),
                "That if thou shalt confess with thy mouth the Lord Jesus, and shalt believe in thine heart that God hath raised him from the dead, thou shalt be saved."
            ),
            new Scripture(
                new ScriptureReference("Matthew", 11, 28),
                "Come unto me, all ye that labour and are heavy laden, and I will give you rest."
            ),
            new Scripture(
                new ScriptureReference("Mark", 11, 24),
                "Therefore I say unto you, What things soever ye desire, when ye pray, believe that ye receive them, and ye shall have them."
            ),
            new Scripture(
                new ScriptureReference("Luke", 1, 37),
                "For with God nothing shall be impossible."
            ),
            new Scripture(
                new ScriptureReference("Proverbs", 16, 3),
                "Commit thy works unto the Lord, and thy thoughts shall be established."
            ),
            new Scripture(
                new ScriptureReference("Psalm", 121, 1, 2),
                "I will lift up mine eyes unto the hills, from whence cometh my help. My help cometh from the Lord, which made heaven and earth."
            ),
            new Scripture(
                new ScriptureReference("John", 14, 6),
                "Jesus saith unto him, I am the way, the truth, and the life: no man cometh unto the Father, but by me."
            ),
            new Scripture(
                new ScriptureReference("Matthew", 28, 18),
                "And Jesus came and spake unto them, saying, All power is given unto me in heaven and in earth."
            ),
            new Scripture(
                new ScriptureReference("1 John", 1, 9),
                "If we confess our sins, he is faithful and just to forgive us our sins, and to cleanse us from all unrighteousness."
            ),
            new Scripture(
                new ScriptureReference("Psalm", 34, 8),
                "O taste and see that the Lord is good: blessed is the man that trusteth in him."
            ),
            new Scripture(
                new ScriptureReference("Romans", 5, 8),
                "But God commendeth his love toward us, in that, while we were yet sinners, Christ died for us."
            ),
            new Scripture(
                new ScriptureReference("Ephesians", 2, 8, 9),
                "For by grace are ye saved through faith; and that not of yourselves: it is the gift of God: Not of works, lest any man should boast."
            ),
            new Scripture(
                new ScriptureReference("James", 1, 12),
                "Blessed is the man that endureth temptation: for when he is tried, he shall receive the crown of life, which the Lord hath promised to them that love him."
            ),
            new Scripture(
                new ScriptureReference("Psalm", 23, 4),
                "Yea, though I walk through the valley of the shadow of death, I will fear no evil: for thou art with me; thy rod and thy staff they comfort me."
            ),
            new Scripture(
                new ScriptureReference("1 Thessalonians", 5, 16, 18),
                "Rejoice evermore. Pray without ceasing. In every thing give thanks: for this is the will of God in Christ Jesus concerning you."
            ),
            new Scripture(
                new ScriptureReference("Hebrews", 13, 5),
                "Let your conversation be without covetousness; and be content with such things as ye have: for he hath said, I will never leave thee, nor forsake thee."
            ),
            new Scripture(
                new ScriptureReference("1 Peter", 1, 3),
                "Blessed be the God and Father of our Lord Jesus Christ, which according to his abundant mercy hath begotten us again unto a lively hope by the resurrection of Jesus Christ from the dead."
            ),
            new Scripture(
                new ScriptureReference("2 Corinthians", 12, 9),
                "And he said unto me, My grace is sufficient for thee: for my strength is made perfect in weakness. Most gladly therefore will I rather glory in my infirmities, that the power of Christ may rest upon me."
            ),
            new Scripture(
                new ScriptureReference("Romans", 8, 1),
                "There is therefore now no condemnation to them which are in Christ Jesus, who walk not after the flesh, but after the Spirit."
            ),
            new Scripture(
                new ScriptureReference("Revelation", 21, 4),
                "And God shall wipe away all tears from their eyes; and there shall be no more death, neither sorrow, nor crying, neither shall there be any more pain: for the former things are passed away."
            ),
            new Scripture(
                new ScriptureReference("John", 15, 13),
                "Greater love hath no man than this, that a man lay down his life for his friends."
            ),
            new Scripture(
                new ScriptureReference("Psalm", 56, 3),
                "What time I am afraid, I will trust in thee."
            ),
            new Scripture(
                new ScriptureReference("Matthew", 5, 3, 12),
                "Blessed are the poor in spirit: for theirs is the kingdom of heaven. Blessed are they that mourn: for they shall be comforted. Blessed are the meek: for they shall inherit the earth. Blessed are they which do hunger and thirst after righteousness: for they shall be filled. Blessed are the merciful: for they shall obtain mercy. Blessed are the pure in heart: for they shall see God. Blessed are the peacemakers: for they shall be called the children of God. Blessed are they which are persecuted for righteousness' sake: for theirs is the kingdom of heaven. Blessed are ye when men shall revile you, and persecute you, and shall say all manner of evil against you falsely, for my sake. Rejoice and be exceeding glad, for great is your reward in heaven: for so persecuted they the prophets which were before you."
            ),
            new Scripture(
                new ScriptureReference("Romans", 8, 28, 39),
                "And we know that all things work together for good to them that love God, to them who are the called according to his purpose. For whom he did foreknow, he also did predestinate to be conformed to the image of his Son, that he might be the firstborn among many brethren. Moreover whom he did predestinate, them he also called: and whom he called, them he also justified: and whom he justified, them he also glorified. What shall we then say to these things? If God be for us, who can be against us? He that spared not his own Son, but delivered him up for us all, how shall he not with him also freely give us all things? Who shall lay any thing to the charge of God's elect? It is God that justifieth. Who is he that condemneth? It is Christ that died, yea rather, that is risen again, who is even at the right hand of God, who also maketh intercession for us. Who shall separate us from the love of Christ? shall tribulation, or distress, or persecution, or famine, or nakedness, or peril, or sword? As it is written, For thy sake we are killed all the day long; we are accounted as sheep for the slaughter. Nay, in all these things we are more than conquerors through him that loved us. For I am persuaded, that neither death, nor life, nor angels, nor principalities, nor powers, nor things present, nor things to come, nor height, nor depth, nor any other creature, shall be able to separate us from the love of God, which is in Christ Jesus our Lord."
            ),
            new Scripture(
                new ScriptureReference("Psalm", 23, 1, 6),
                "The Lord is my shepherd; I shall not want. He maketh me to lie down in green pastures: he leadeth me beside the still waters. He restoreth my soul: he leadeth me in the paths of righteousness for his name's sake. Yea, though I walk through the valley of the shadow of death, I will fear no evil: for thou art with me; thy rod and thy staff they comfort me. Thou preparest a table before me in the presence of mine enemies: thou anointest my head with oil; my cup runneth over. Surely goodness and mercy shall follow me all the days of my life: and I will dwell in the house of the Lord for ever."
            ),
            new Scripture(
                new ScriptureReference("Isaiah", 40, 28, 31),
                "Hast thou not known? hast thou not heard, that the everlasting God, the Lord, the Creator of the ends of the earth, fainteth not, neither is weary? there is no searching of his understanding. He giveth power to the faint; and to them that have no might he increaseth strength. Even the youths shall faint and be weary, and the young men shall utterly fall: but they that wait upon the Lord shall renew their strength; they shall mount up with wings as eagles; they shall run, and not be weary; and they shall walk, and not faint."
            ),
            new Scripture(
                new ScriptureReference("Philippians", 4, 6, 7),
                "Be careful for nothing; but in every thing by prayer and supplication with thanksgiving let your requests be made known unto God. And the peace of God, which passeth all understanding, shall keep your hearts and minds through Christ Jesus."
            ),
            new Scripture(
                new ScriptureReference("2 Corinthians", 4, 16, 18),
                "For which cause we faint not; but though our outward man perish, yet the inward man is renewed day by day. For our light affliction, which is but for a moment, worketh for us a far more exceeding and eternal weight of glory; While we look not at the things which are seen, but at the things which are not seen: for the things which are seen are temporal; but the things which are not seen are eternal."
            ),
            new Scripture(
                new ScriptureReference("Matthew", 6, 9, 13),
                "After this manner therefore pray ye: Our Father which art in heaven, Hallowed be thy name. Thy kingdom come. Thy will be done in earth, as it is in heaven. Give us this day our daily bread. And forgive us our debts, as we forgive our debtors. And lead us not into temptation, but deliver us from evil: For thine is the kingdom, and the power, and the glory, for ever. Amen."
            ),
            new Scripture(
                new ScriptureReference("Ephesians", 6, 10, 18),
                "Finally, my brethren, be strong in the Lord, and in the power of his might. Put on the whole armour of God, that ye may be able to stand against the wiles of the devil. For we wrestle not against flesh and blood, but against principalities, against powers, against the rulers of the darkness of this world, against spiritual wickedness in high places. Wherefore take unto you the whole armour of God, that ye may be able to withstand in the evil day, and having done all, to stand. Stand therefore, having your loins girt about with truth, and having on the breastplate of righteousness; And your feet shod with the preparation of the gospel of peace; Above all, taking the shield of faith, wherewith ye shall be able to quench all the fiery darts of the wicked. And take the helmet of salvation, and the sword of the Spirit, which is the word of God: Praying always with all prayer and supplication in the Spirit, and watching thereunto with all perseverance and supplication for all saints."
            ),
            new Scripture(
                new ScriptureReference("John", 15, 12, 17),
                "This is my commandment, That ye love one another, as I have loved you. Greater love hath no man than this, that a man lay down his life for his friends. Ye are my friends, if ye do whatsoever I command you. Henceforth I call you not servants; for the servant knoweth not what his lord doeth: but I have called you friends; for all things that I have heard of my Father I have made known unto you. Ye have not chosen me, but I have chosen you, and ordained you, that ye should go and bring forth fruit, and that your fruit should remain: that whatsoever ye shall ask of the Father in my name, he may give it you. These things I command you, that ye love one another."
            )
        };
    }

    static void Main(string[] args)
    {
        // Populates the scriptures list and chooses random scripture each time
        List<Scripture> scriptures = GetScriptureList();
        Random random = new Random();

        while (true)
        {
            // Select a random scripture
            Scripture scripture = scriptures[random.Next(scriptures.Count)];

            // Reset all hidden words for the new scripture
            scripture.ResetHiddenWords();

            // Display the full scripture first before hiding any words
            Console.Clear();
            Console.WriteLine("<-------------------------------------------->");
            Console.WriteLine("\nPress Enter to begin, or type 'exit' to quit.");

            string input = Console.ReadLine();
            if (input.Trim().ToLower() == "exit")
            {
                return; // Exit the program if the user types "exit"
            }

            // Clear console and continue hiding words until all words are hidden
            while (true)
            {
                Console.Clear();
                Console.WriteLine(scripture.Display());
                Console.WriteLine("\nPress Enter to hide more words, or type 'exit' to quit.");

                input = Console.ReadLine();
                if (input.Trim().ToLower() == "exit")
                {
                    return; // Exit the program if the user types "exit"
                }

                // Hide random three words
                scripture.HideRandomWords(3);

                // Clear console, check if all words are hidden
                if (scripture.IsFullyHidden())
                {
                    Console.Clear();
                    Console.WriteLine(scripture.Display());
                    Console.WriteLine("\nAll words are hidden! Press Enter to choose a new scripture or type 'exit' to quit.");

                    input = Console.ReadLine();
                    if (input.Trim().ToLower() == "exit")
                    {
                        return; // Exit the program if the user types "exit"
                    }
                    else
                    {
                        break; // Exit the inner loop to pick a new random scripture
                    }
                }
            }
        }
    }
}