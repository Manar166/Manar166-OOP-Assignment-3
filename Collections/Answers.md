```text

S1 Find a student by national ID — thousands of times a day.

collection Type : Dictionary<string, Student>

why:It gives O(1) lookup thousands of times per day 


-----------------------------

S2 Keep the tags of a course. The same tag must never be stored twice.

Collection Type: HashSet 
Why: It automatically guarantees element uniqueness and prevents duplicate entries 
And offering $O(1)$ performance for insertions and checks.
------------------------------

S3 Keep a student's grades in the order they were entered. The same grade can appear more than once.

collection Type: List<double>   

why: List preserves insertion order and allows duplicates
------------------------------


S4 A public method returns the course price list. Callers can read prices but must not add or change any.

collection Type: IReadOnlyList

why: It provides a read-only value view that prevents callers from modifying, adding, or removing any price entries
------------------------------

S5 A timetable keyed by session start time. Sessions are added at any moment, and it must always print in
time order.

collection Type:Sorted Dictionnary<DateTime,session>

why: you can add at any time ,and it stores the values by key automatically


------------------------------

S6 A method returns results that the caller only loops over once — and may stop early
Collection Type: IEnumerable

Why: It supports deferred execution and lazy evaluation, allowing the consumer to iterate through items on-the-fly and stop early without generating or processing the remaining elements.


```