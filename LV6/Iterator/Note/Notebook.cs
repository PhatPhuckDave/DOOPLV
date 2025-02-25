﻿using System.Collections.Generic;

namespace Iterator.Note
{
    class Notebook : IAbstractCollection
    {
        private List<Note> notes;
        public Notebook() {
            notes = new List<Note>();
        }
        public Notebook(List<Note> notes) {
            this.notes = new List<Note>(notes.ToArray());
        }

        public void AddNote(Note note) => this.notes.Add(note);
        public void RemoveNote(Note note) => this.notes.Remove(note);
        public void Clear() => this.notes.Clear();

        public int Count { get { return this.notes.Count; } }
        public Note this[int index] { get { return this.notes[index]; } }
        public IAbstractIterator GetIterator() { return new Iterator(this); }
    }

}
