//
//  MTRGNativeAdView.h
//  myTargetSDK 5.9.11
//
//  Created by Anton Bulankin on 05.12.14.
//  Copyright (c) 2014 Mail.ru Group. All rights reserved.
//

#import <UIKit/UIKit.h>

@class MTRGPromoCardCollectionView;
@class MTRGNativePromoBanner;
@class MTRGStarsRatingLabel;
@class MTRGMediaAdView;
@class MTRGIconAdView;

NS_ASSUME_NONNULL_BEGIN

@interface MTRGNativeAdView : UIView

@property(nonatomic, nullable) MTRGNativePromoBanner *banner;
@property(nonatomic, nullable) UIColor *backgroundColor;

@property(nonatomic, readonly) UILabel *ageRestrictionsLabel;
@property(nonatomic, readonly) UILabel *adLabel;
@property(nonatomic, readonly) UILabel *titleLabel;
@property(nonatomic, readonly) UILabel *descriptionLabel;
@property(nonatomic, readonly) MTRGIconAdView *iconAdView;
@property(nonatomic, readonly) MTRGMediaAdView *mediaAdView;
@property(nonatomic, readonly, nullable) MTRGPromoCardCollectionView *cardCollectionView;
@property(nonatomic, readonly) UILabel *domainLabel;
@property(nonatomic, readonly) UILabel *categoryLabel;
@property(nonatomic, readonly) UILabel *disclaimerLabel;
@property(nonatomic, readonly) MTRGStarsRatingLabel *ratingStarsLabel;
@property(nonatomic, readonly) UILabel *votesLabel;
@property(nonatomic, readonly) UIView *buttonView;
@property(nonatomic, readonly) UILabel *buttonToLabel;

@property(nonatomic) UIEdgeInsets contentMargins;
@property(nonatomic) UIEdgeInsets adLabelMargins;
@property(nonatomic) UIEdgeInsets ageRestrictionsMargins;
@property(nonatomic) UIEdgeInsets titleMargins;
@property(nonatomic) UIEdgeInsets domainMargins;
@property(nonatomic) UIEdgeInsets categoryMargins;
@property(nonatomic) UIEdgeInsets descriptionMargins;
@property(nonatomic) UIEdgeInsets disclaimerMargins;
@property(nonatomic) UIEdgeInsets imageMargins;
@property(nonatomic) UIEdgeInsets iconMargins;
@property(nonatomic) UIEdgeInsets ratingStarsMargins;
@property(nonatomic) UIEdgeInsets votesMargins;
@property(nonatomic) UIEdgeInsets buttonMargins;
@property(nonatomic) UIEdgeInsets buttonCaptionMargins;

+ (instancetype)create;

+ (instancetype)createWithExtendedCard;

@end

NS_ASSUME_NONNULL_END
