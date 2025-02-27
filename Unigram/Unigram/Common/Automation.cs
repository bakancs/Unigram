﻿using System.Linq;
using System.Text;
using Telegram.Td.Api;
using Unigram.Controls.Messages;
using Unigram.Converters;
using Unigram.Services;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Automation;
using Windows.UI.Xaml.Controls;

namespace Unigram.Common
{
    public static class Automation
    {
        public static void SetToolTip(DependencyObject element, string text)
        {
            AutomationProperties.SetName(element, text);
            ToolTipService.SetToolTip(element, text);
        }

        public static string GetSummary2(Message message)
        {
            var builder = new StringBuilder();

            if (message.Content is MessagePhoto photo)
            {
                builder.Append($"{Strings.Resources.AttachPhoto}");

                if (photo.Caption != null && !string.IsNullOrEmpty(photo.Caption.Text))
                {
                    builder.Append($". {photo.Caption.Text}");
                }
            }
            else if (message.Content is MessageVoiceNote voiceNote)
            {
                builder.Append($"{Strings.Resources.AttachAudio}");

                if (voiceNote.Caption != null && !string.IsNullOrEmpty(voiceNote.Caption.Text))
                {
                    builder.Append($". {voiceNote.Caption.Text}");
                }
            }
            else if (message.Content is MessageVideo video)
            {
                builder.Append($"{Strings.Resources.AttachVideo}");

                if (video.Caption != null && !string.IsNullOrEmpty(video.Caption.Text))
                {
                    builder.Append($". {video.Caption.Text}");
                }
            }
            else if (message.Content is MessageVideoNote)
            {
                builder.Append($"{Strings.Resources.AttachRound}");
            }
            else if (message.Content is MessageAnimation animation)
            {
                builder.Append($". {Strings.Resources.AttachGif}");

                if (animation.Caption != null && !string.IsNullOrEmpty(animation.Caption.Text))
                {
                    builder.Append($". {animation.Caption.Text}");
                }
            }
            else if (message.Content is MessageSticker sticker)
            {
                if (!string.IsNullOrEmpty(sticker.Sticker.Emoji))
                {
                    builder.Append($"{sticker.Sticker.Emoji} {Strings.Resources.AttachSticker}");
                }
                else
                {
                    builder.Append($"{Strings.Resources.AttachSticker}");
                }
            }
            else if (message.Content is MessageAudio audio)
            {
                builder.Append($"{Strings.Resources.AttachMusic}");

                if (audio.Caption != null && !string.IsNullOrEmpty(audio.Caption.Text))
                {
                    builder.Append($". {audio.Caption.Text}");
                }
            }
            else if (message.Content is MessageLocation)
            {
                builder.Append($"{Strings.Resources.AttachLocation}");
            }
            else if (message.Content is MessageVenue venue)
            {
                builder.Append($"{Strings.Resources.AttachLocation}");
                builder.Append(venue.Venue.Title);
                builder.Append(venue.Venue.Address);
            }
            else if (message.Content is MessageContact contact)
            {
                builder.Append($"{Strings.Resources.AttachContact}");
                builder.Append(contact.Contact.GetFullName());
                builder.Append(PhoneNumber.Format(contact.Contact.PhoneNumber));
            }
            else if (message.Content is MessagePoll poll)
            {
                builder.Append($"{Strings.Resources.Poll}. ");
                builder.Append($"{poll.Poll.Question}");
            }
            else if (message.Content is MessageCall call)
            {
                builder.Append(call.ToOutcomeText(message.IsOutgoing));
            }
            else if (message.Content is MessageText text)
            {
                builder.Append(text.Text.Text);
            }
            else if (message.Content is MessageDice dice)
            {
                builder.Append(dice.Emoji);
            }

            if (builder.Length > 0 && builder[builder.Length - 1] != '.')
            {
                builder.Append(". ");
            }
            else
            {
                builder.Append(" ");
            }

            return builder.ToString();
        }

        public static string GetSummary(IProtoService protoService, Message message, bool details = false)
        {
            if (message.IsService())
            {
                return MessageService.GetText(new ViewModels.MessageViewModel(protoService, null, null, message)) + ", ";
            }

            if (message.Content is MessageAlbum album)
            {
                if (album.IsMedia)
                {
                    var photos = album.Messages.Count(x => x.Content is MessagePhoto);
                    var videos = album.Messages.Count - photos;

                    if (album.Messages.Count > 0 && album.Messages[0].Content is MessageVideo)
                    {
                        return Locale.Declension("Videos", videos) + ", " + Locale.Declension("Photos", photos) + ", ";
                    }

                    return Locale.Declension("Photos", photos) + ", " + Locale.Declension("Videos", videos) + ", ";
                }
                else if (album.Messages.Count > 0 && album.Messages[0].Content is MessageAudio)
                {
                    return Locale.Declension("MusicFiles", album.Messages.Count) + ", ";
                }
                else
                {
                    return Locale.Declension("Files", album.Messages.Count) + ", ";
                }
            }
            if (message.Content is MessageText text)
            {
                return text.Text.Text + ", ";
            }
            if (message.Content is MessageDice dice)
            {
                return dice.Emoji + ", ";
            }
            if (message.Content is MessageGame gameMedia)
            {
                return Strings.Resources.AttachGame + ", " + gameMedia.Game.Title + ", ";
            }
            if (message.Content is MessageExpiredVideo)
            {
                return Strings.Resources.AttachVideoExpired + ", ";
            }
            else if (message.Content is MessageExpiredPhoto)
            {
                return Strings.Resources.AttachPhotoExpired + ", ";
            }
            else if (message.Content is MessageVideoNote)
            {
                return Strings.Resources.AttachRound + ", ";
            }
            else if (message.Content is MessageSticker sticker)
            {
                if (string.IsNullOrEmpty(sticker.Sticker.Emoji))
                {
                    return Strings.Resources.AttachSticker + ", ";
                }

                return $"{sticker.Sticker.Emoji} {Strings.Resources.AttachSticker}" + ", ";
            }

            string GetCaption(string caption)
            {
                return string.IsNullOrEmpty(caption) ? string.Empty : ", " + caption;
            }

            if (message.Content is MessageVoiceNote voiceNote)
            {
                var result = Strings.Resources.AttachAudio + GetCaption(voiceNote.Caption.Text) + ", " + (voiceNote.IsListened ? "" : Strings.Resources.AccDescrMsgNotPlayed + ", ");

                if (details)
                {
                    result += voiceNote.VoiceNote.GetDuration() + ", ";
                }

                return result;
            }
            else if (message.Content is MessageVideo video)
            {
                var result = (video.IsSecret ? Strings.Resources.AttachDestructingVideo : Strings.Resources.AttachVideo) + GetCaption(video.Caption.Text) + ", ";

                if (details)
                {
                    result += video.Video.GetDuration() + ", ";
                }

                if (details && !video.Video.VideoValue.Local.IsDownloadingCompleted)
                {
                    result += FileSizeConverter.Convert(video.Video.VideoValue.Size) + ", ";
                }

                return result;
            }
            else if (message.Content is MessageAnimation animation)
            {
                var result = Strings.Resources.AttachGif + GetCaption(animation.Caption.Text) + ", ";
                if (details)
                {
                    result += FileSizeConverter.Convert(animation.Animation.AnimationValue.Size) + ", ";
                }

                return result;
            }
            else if (message.Content is MessageAudio audio)
            {
                var performer = string.IsNullOrEmpty(audio.Audio.Performer) ? null : audio.Audio.Performer;
                var title = string.IsNullOrEmpty(audio.Audio.Title) ? null : audio.Audio.Title;

                string result;
                if (performer == null && title == null)
                {
                    result = Strings.Resources.AttachMusic + GetCaption(audio.Caption.Text) + ", ";
                }
                else
                {
                    result = $"{performer ?? Strings.Resources.AudioUnknownArtist} - {title ?? Strings.Resources.AudioUnknownTitle}" + GetCaption(audio.Caption.Text) + ", ";
                }

                if (details)
                {
                    result += audio.Audio.GetDuration() + ", ";
                }

                if (details && !audio.Audio.AudioValue.Local.IsDownloadingCompleted)
                {
                    result += FileSizeConverter.Convert(audio.Audio.AudioValue.Size) + ", ";
                }

                return result;
            }
            else if (message.Content is MessageDocument document)
            {
                string result;
                if (string.IsNullOrEmpty(document.Document.FileName))
                {
                    result = Strings.Resources.AttachDocument + GetCaption(document.Caption.Text) + ", ";
                }
                else
                {
                    result = document.Document.FileName + GetCaption(document.Caption.Text) + ", ";
                }

                if (details)
                {
                    result += FileSizeConverter.Convert(document.Document.DocumentValue.Size) + ", ";
                }

                return result;
            }
            else if (message.Content is MessageInvoice invoice)
            {
                return Strings.Resources.PaymentInvoice + ", " + invoice.Title + ", ";
            }
            else if (message.Content is MessageContact)
            {
                return Strings.Resources.AttachContact + ", ";
            }
            else if (message.Content is MessageLocation location)
            {
                return (location.LivePeriod > 0 ? Strings.Resources.AttachLiveLocation : Strings.Resources.AttachLocation) + ", ";
            }
            else if (message.Content is MessageVenue)
            {
                return Strings.Resources.AttachLocation + ", ";
            }
            else if (message.Content is MessagePhoto photo)
            {
                return (photo.IsSecret ? Strings.Resources.AttachDestructingPhoto : Strings.Resources.AttachPhoto) + GetCaption(photo.Caption.Text) + ", ";
            }
            else if (message.Content is MessagePoll poll)
            {
                if (details)
                {
                    string type = null;
                    if (poll.Poll.Type is PollTypeRegular)
                    {
                        type = poll.Poll.IsClosed ? Strings.Resources.FinalResults : poll.Poll.IsAnonymous ? Strings.Resources.AnonymousPoll : Strings.Resources.PublicPoll;
                    }
                    else if (poll.Poll.Type is PollTypeQuiz)
                    {
                        type = poll.Poll.IsClosed ? Strings.Resources.FinalResults : poll.Poll.IsAnonymous ? Strings.Resources.AnonymousQuizPoll : Strings.Resources.QuizPoll;
                    }

                    if (type != null)
                    {
                        return type + ", " + poll.Poll.Question + ", ";
                    }
                }

                return Strings.Resources.Poll + ", " + poll.Poll.Question + ", ";
            }
            else if (message.Content is MessageCall call)
            {
                return call.ToOutcomeText(message.IsOutgoing) + ", ";
            }
            else if (message.Content is MessageUnsupported)
            {
                return Strings.Resources.UnsupportedAttachment + ", ";
            }

            return null;
        }

        public static string GetDescription(IProtoService cacheService, Message message)
        {
            var chat = cacheService.GetChat(message.ChatId);
            var content = message.Content;

            var sticker = content is MessageSticker;
            var light = sticker || content is MessageVideoNote;

            var title = string.Empty;

            if (!light && /*message.IsFirst &&*/ !message.IsOutgoing && !message.IsChannelPost && (chat.Type is ChatTypeBasicGroup || chat.Type is ChatTypeSupergroup))
            {
                if (cacheService.TryGetUser(message.SenderId, out User senderUser))
                {
                    title = senderUser.GetFullName();
                }
                else if (cacheService.TryGetChat(message.SenderId, out Chat senderChat))
                {
                    title = senderChat.Title;
                }
            }
            else if (!light && message.IsChannelPost && chat.Type is ChatTypeSupergroup)
            {
                title = cacheService.GetTitle(chat);
            }
            else if (!light && /*message.IsFirst &&*/ message.IsSaved(cacheService.Options.MyId))
            {
                title = cacheService.GetTitle(message.ForwardInfo);
            }

            var builder = new StringBuilder();
            if (title?.Length > 0)
            {
                builder.AppendLine($"{title}. ");
            }

            //if (message.ReplyToMessage != null)
            //{
            //    var user = message.ProtoService.GetUser(message.ReplyToMessage.SenderUserId);
            //    if (user != null)
            //    {
            //        builder.AppendLine($"{Strings.Resources.AccDescrReplying} {user.GetFullName()}. ");
            //    }
            //}

            builder.Append(GetSummary(cacheService, message));

            var date = string.Format(Strings.Resources.TodayAtFormatted, Converter.ShortTime.Format(Utils.UnixTimestampToDateTime(message.Date)));
            if (message.IsOutgoing)
            {
                builder.Append(string.Format(Strings.Resources.AccDescrSentDate, date));
            }
            else
            {
                builder.Append(string.Format(Strings.Resources.AccDescrReceivedDate, date));
            }

            builder.Append(". ");

            var maxId = 0L;
            if (chat != null)
            {
                maxId = chat.LastReadOutboxMessageId;
            }

            if (message.SendingState is MessageSendingStateFailed)
            {
            }
            else if (message.SendingState is MessageSendingStatePending)
            {
            }
            else if (message.Id <= maxId)
            {
                builder.Append(Strings.Resources.AccDescrMsgRead);
            }
            else
            {
                builder.Append(Strings.Resources.AccDescrMsgUnread);
            }

            builder.Append(".");

            return builder.ToString();
        }
    }
}
