﻿using System;
using GalaSoft.MvvmLight;
using System.Collections.ObjectModel;
using GalaSoft.MvvmLight.Command;

namespace MvvmLightStart
{
	public class ListViewModel:ViewModelBase
	{
		public ListViewModel ()
		{
			NewItem = "";
			Items = new ObservableCollection<TodoItem>() {
				new TodoItem(){
					Name="Fix some bug",
				},

				new TodoItem(){
					Name = "Deploy App"
				},

				new TodoItem(){
					Name ="Make millions of dollars"
				}
			};

		}

		public String NewItem {
			get;
			set;
		}

		public ObservableCollection<TodoItem>Items {
			get ;
			set ; 
		}

		public RelayCommand AddItem {
			get {
				return _addItem ?? (_addItem = new RelayCommand (() => AddNewItem ()));
			}
		}

		private RelayCommand _addItem;

		private void AddNewItem()
		{
			if (NewItem.Trim().Length > 0) {
				
				Items.Add (new TodoItem (){ Name = NewItem });
				NewItem = "";
				RaisePropertyChanged ("NewItem");
			}
		}

		private ObservableCollection<TodoItem> _items;
	}
}

