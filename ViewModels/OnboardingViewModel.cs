using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ProjetoOnboardingPage.Models;
using System.Collections.ObjectModel;

namespace ProjetoOnboardingPage.ViewModels
{
    public partial class OnboardingViewModel :ObservableObject
    {
        [ObservableProperty]
        private List<OnBoardingItem> _items;

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(IsLastPosition))]
        [NotifyPropertyChangedFor(nameof(ShowButton))]
        [NotifyPropertyChangedFor(nameof(SpanGrid))]
        private int _position;

        public bool IsLastPosition => Position == Items.Count - 1;
        public bool ShowButton => !IsLastPosition;

        public int SpanGrid => IsLastPosition ? 2 : 1;

        public OnboardingViewModel()
        {
            Items = new List<OnBoardingItem>
            {
                new OnBoardingItem
                {
                    Titulo = "Compre agora!",
                    Descricao = "Qualquer hora, qualquer lugar.",
                    ImagemUrl = "shop.png"
                },
                new OnBoardingItem
                {
                    Titulo = "Frete Grátis",
                    Descricao = "Receba em casa ou retire na loja.",
                    ImagemUrl = "shipping.png"
                },
                new OnBoardingItem
                {
                    Titulo = "Pague como quiser",
                    Descricao = "Cartão, Pix, Boleto ou na entrega.",
                    ImagemUrl = "payment.png"
                }
            };
        }

        [RelayCommand]
        private void Next()
        {
            if (Position < Items.Count - 1)
            {
                Position++;
            }
        }

    }
}
