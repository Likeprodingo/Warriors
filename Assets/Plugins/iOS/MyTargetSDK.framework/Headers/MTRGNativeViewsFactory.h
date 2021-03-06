//
//  MTRGNativeViewsFactory.h
//  myTargetSDK 5.9.11
//
//  Created by Anton Bulankin on 17.11.14.
//  Copyright (c) 2014 Mail.ru Group. All rights reserved.
//

#import <Foundation/Foundation.h>

@class MTRGNativeBannerAdView;
@class MTRGNativeAdView;
@class MTRGMediaAdView;
@class MTRGIconAdView;
@class MTRGNativeCardAdView;
@class MTRGPromoCardCollectionView;

NS_ASSUME_NONNULL_BEGIN

@interface MTRGNativeViewsFactory : NSObject

+ (MTRGNativeBannerAdView *)createNativeBannerAdView;

+ (MTRGNativeAdView *)createNativeAdView;

+ (MTRGNativeAdView *)createNativeAdViewWithExtendedCard;

+ (MTRGMediaAdView *)createMediaAdView;

+ (MTRGIconAdView *)createIconAdView;

+ (MTRGNativeCardAdView *)createNativeCardAdView;

+ (MTRGPromoCardCollectionView *)createPromoCardCollectionView;

@end

NS_ASSUME_NONNULL_END
